using UnityEngine;

public class minigun : gun
{
    public override void Start()
    {
        base.Start();
        damage = 3;
        range = 50;
        firerate = 0.000001f;
        reloadSpeed = 0f;
        ammo = 999999;
        maxAmmo = ammo;
        bug = "minigun BOOM";
    }

    public override void Fire()
    {
        base.Fire();
    }
    public override void Reload()
    {
        base.Reload();
    }
}
