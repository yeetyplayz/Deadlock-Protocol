using UnityEngine;
using System.Collections;

public class sniper : gun
{
    private void Start()
    {
        damage = 50f;
        firerate = 2.5f;
        reloadSpeed = 4.3f;
        ammo = 5;
        maxAmmo = 5;
        bug = "sniper BOOM";
    }
    public override void Fire()
    {
        base.Fire();
    }
    public override void Reload()
    {
        base.Reload();
    }
    public void Update()
    {
        if (pew = false && ammo > 0 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
        if (isReloading = false && ammo < maxAmmo && Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }
}
