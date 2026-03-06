using UnityEngine;
using UnityEngine.SocialPlatforms;

public class gunBehaviour : MonoBehaviour
{
    [Header("Kind of Gun")]
    public bool pistol;
    public AudioSource pistolShot;
    public bool shotgun;
    private int shotgunBullets = 8;
    public bool machineGun;
    public bool miniGun;
    public bool rifle;
    public bool sniper;
    private int curAmmo;
    private int curMaxAmmo;

    private float laserRange;
    private Vector3 localGameObjectLocation;
    private RaycastHit hit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        localGameObjectLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (pistol)
            {
                laserRange = 100;
                UsePistol();
            }
            if (shotgun) 
            {
                while (shotgunBullets > 0)
                {
                    shotgunBullets--;
                }
            }
            if (machineGun)
            { 
            
            }
            if (miniGun) 
            {
            
            }
            if (rifle)
            {

            }
            if (sniper)
            {

            }
            else 
            {
                Debug.Log("PROBLEM: NO GUN FOUND");
            }
        }
    }
    private void UsePistol()
    {
        Physics.Raycast(localGameObjectLocation, Vector3.forward, out RaycastHit hit, laserRange);
        Debug.Log(hit);
        pistolShot.Play();
    }
}
