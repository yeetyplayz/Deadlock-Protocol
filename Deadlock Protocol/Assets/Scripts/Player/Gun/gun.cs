using UnityEngine;

public class gun : MonoBehaviour
{
    [Header("Gun Settings")]
    public float damage;
    public float firerate;
    public float reloadSpeed;
    public int ammo;
    public int maxAmmo;
    public virtual void Fire()
    {
        Debug.Log("BOOM");
    }
    public virtual void Reload()
    {
        Debug.Log("Realoading...");
    }

    public void Update()
    {
        if(ammo > 0 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
        if(ammo == 0 && Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }
}
