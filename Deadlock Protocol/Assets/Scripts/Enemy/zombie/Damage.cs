using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 10;

    private void OnCollisionEnter(Collision collision)
    {
        // Pak het Player script (pas naam aan als jouw script anders heet)
        player player = collision.gameObject.GetComponent<player>();

        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }
}
