using UnityEngine;

public class gun : MonoBehaviour
{
    [Header("Gun Settings")]
    public float damage;
    public float firerate;
    public float reloadSpeed;
    public int ammo;
    public int maxAmmo;
    public void Fire()
    {
        Debug.Log("BOOM");
    }
    public void Reload()
    {
        Debug.Log("Realoading...");
    }
}
