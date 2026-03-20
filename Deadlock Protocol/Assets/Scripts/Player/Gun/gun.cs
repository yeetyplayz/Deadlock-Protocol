using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;

public class gun : MonoBehaviour
{
    [Header("Gun Settings")]
    public int damage;
    public float range;
    public float firerate;
    public float reloadSpeed;
    private bool isReloading;
    private float switchDelay = 1.5f;
    private bool pew;
    public int ammo;
    public int maxAmmo;
    public string bug;
    public Camera fpsCam;
    public ZombieHealth zombieHealth;
    public AudioSource gunSound;
    public AudioClip gunShotSound;
    public AudioClip gunReloadSound;

    private sniper sniper;
    private pistol pistol;
    private rifle rifle;
    private machineGun machineGun;
    private minigun minigun;

    public virtual void Start()
    {
        fpsCam = Camera.main;
        gunSound = GetComponent<AudioSource>();
        sniper = GetComponent<sniper>();
        pistol = GetComponent<pistol>();
        rifle = GetComponent<rifle>();
        machineGun = GetComponent<machineGun>();
        minigun = GetComponent<minigun>();
        SwitchTo(sniper);
    }
    public virtual void Fire()
    {
        if(!pew)
        {
            gunSound.PlayOneShot(gunShotSound);
            StartCoroutine(FireRoutine());
        }
    }
    public virtual void Reload()
    {
        if(!isReloading)
        {
            gunSound.PlayOneShot(gunReloadSound);
            StartCoroutine(ReloadRoutine());
        }
    }
    IEnumerator ReloadRoutine()
    {
        isReloading = true;
        Debug.Log("Reloading...");
        yield return new WaitForSeconds(reloadSpeed);
        Debug.Log("Reload complete!");
        ammo = maxAmmo;
        isReloading = false;
    }

    IEnumerator FireRoutine()
    {
        pew = true;
        --ammo;
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if (hit.transform != null && hit.transform.CompareTag("Zombie"))
            {
                zombieHealth = hit.transform.GetComponent<ZombieHealth>();
                if (zombieHealth != null)
                {
                    zombieHealth.TakeDamage(damage);
                }
            }
            else
            {
                Debug.Log("learn to shoot");
            }
        }
        Debug.Log("bug");
        yield return new WaitForSeconds(firerate);
        pew = false;
    }

        public void Update()
    {
        if (switchDelay >= 0)
        {
            switchDelay -= Time.deltaTime;
        }
        if (!pew && !isReloading && ammo > 0 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
        if (!isReloading && ammo < maxAmmo && Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
        if (switchDelay <= 0 && Input.GetKeyDown(KeyCode.F))
        {
            SwitchGun(1);
            switchDelay = 1.5f;
        }
    }
    private void SwitchGun(int gun)
    {
        int curGun = 1;
        curGun += gun;
        if (curGun == 1)
        {
            SwitchTo(sniper);
        }
        if (curGun == 2)
        {
            SwitchTo(pistol);
        }
        if (curGun == 3)
        {
            SwitchTo(rifle);
        }
        if (curGun == 4)
        {
            SwitchTo(machineGun);
        }
        if(curGun == 5)
        {
            SwitchTo(minigun);
        }
        if(curGun == 6)
        {
            curGun = 1;
        }
    }
    private void SwitchTo(Behaviour switchTo)
    {
        sniper.enabled = false;
        pistol.enabled = false;
        rifle.enabled = false;
        machineGun.enabled = false;
        minigun.enabled = false;

        switchTo.enabled = true;
    }
}
