using UnityEngine;

public class pistol : gun
{
    public override void Start()
    {
        base.Start();
        damage = 14;
        range = 100;
        firerate = 0f;
        reloadSpeed = 0f;
        ammo = 12;
        maxAmmo = ammo;
        bug = "pistol BOOM";
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
