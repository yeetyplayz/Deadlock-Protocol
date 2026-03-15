using UnityEngine;

public class sniper : gun
{
    private void Start()
    {
        damage = 50f;
        firerate = 3.4f;
        reloadSpeed = 5.2f;
        ammo = 5;
        maxAmmo = ammo;
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
}