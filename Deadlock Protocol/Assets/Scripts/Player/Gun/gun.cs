using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour
{
    [Header("Gun Settings")]
    public float damage;
    public float firerate;
    public float reloadSpeed;
    private bool isReloading;
    private bool pew;
    public int ammo;
    public int maxAmmo;
    public string bug;
    public AudioSource gunSound;
    public AudioClip gunShotSound;
    public AudioClip gunReloadSound;

    private void Start()
    {
        gunSound = GetComponent<AudioSource>();
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
        Debug.Log(bug);
        yield return new WaitForSeconds(firerate);
        pew = false;
    }

        public void Update()
    {
        if (!pew && !isReloading && ammo > 0 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
        if (!isReloading && ammo < maxAmmo && Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }
}
