using UnityEngine;

public class pistol : gun
{
    private void Start()
    {
        damage = 13.6f;
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
