using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour
{
    [Header("Gun Settings")]
    public float damage;
    public float firerate;
    public float reloadSpeed;
    public bool isReloading;
    public bool pew;
    public int ammo;
    public int maxAmmo;
    public string bug;
    public virtual void Fire()
    {
        if(pew == false)
        {
            StartCoroutine(FireRoutine());
        }
    }
    public virtual void Reload()
    {
        if(isReloading == false)
        {
            StartCoroutine(ReloadRoutine());
        }
    }
    IEnumerator ReloadRoutine()
    {
        isReloading = true;
        Debug.Log("Reloading...");
        yield return new WaitForSeconds(reloadSpeed);
        Debug.Log("Reload complete!");
        ammo = maxAmmo;
        isReloading = false;
    }

    IEnumerator FireRoutine()
    {
        pew = true;
        --ammo;
        Debug.Log(bug);
        yield return new WaitForSeconds(firerate);
        pew = false;
    }

    
}
