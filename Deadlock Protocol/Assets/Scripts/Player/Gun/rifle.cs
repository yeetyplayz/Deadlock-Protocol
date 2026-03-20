using UnityEngine;

public class rifle : gun
{
    public override void Start()
    {
        base.Start();
        damage = 200;
        range = 300;
        firerate = 0f;
        reloadSpeed = 6.7f;
        ammo = 1;
        maxAmmo = ammo;
        bug = "rifle BOOM";
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
