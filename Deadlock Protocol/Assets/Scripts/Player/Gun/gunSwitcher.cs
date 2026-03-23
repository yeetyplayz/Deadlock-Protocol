using UnityEngine;

public class gunSwitcher : MonoBehaviour
{
    private float switchDelay;
    private sniper sniper;
    private pistol pistol;
    private rifle rifle;
    private machineGun machineGun;
    private minigun minigun;

    private void Start()
    {
        sniper = GetComponent<sniper>();
        pistol = GetComponent<pistol>();
        rifle = GetComponent<rifle>();
        machineGun = GetComponent<machineGun>();
        minigun = GetComponent<minigun>();
    }
    private void Update()
    {
        if (switchDelay >= 0)
        {
            switchDelay -= Time.deltaTime;
        }
        if (switchDelay <= 0 && Input.GetKeyDown(KeyCode.F))
        {
            SwitchGun(1);
        }
    }
    private void SwitchGun(int wow)
    {
        int gun = 0;
        gun += wow;
        if (gun == 0)
        {
            Switcheroo(sniper);
        }
        if (gun == 1)
        {
            Switcheroo(pistol);
        }
        if (gun == 2)
        {
            Switcheroo(rifle);
        }
        if (gun == 3)
        {
            Switcheroo(machineGun);
        }
        if (gun == 4)
        {
            Switcheroo(minigun);
        }
    }
    private void Switcheroo(Behaviour gun)
    {
        sniper.enabled = false;
        pistol.enabled = false;
        rifle.enabled = false;
        machineGun.enabled = false;
        minigun.enabled = false;

        gun.enabled = true;
    }
}