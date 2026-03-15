using UnityEngine;

public class rifle : gun
{
    private void Start()
    {
        damage = 200f;
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
