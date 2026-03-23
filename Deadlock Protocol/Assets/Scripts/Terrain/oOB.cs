using UnityEngine;

public class oOB : MonoBehaviour
{
     ZombieHealth zHealth;
    private player pHealth;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            pHealth = collision.transform.GetComponent<player>();
            pHealth.Die();
        }
        if (collision.transform.CompareTag("Zombie"))
        {
            zHealth = collision.transform.GetComponent<ZombieHealth>();
            zHealth.Die();
        }
    }
}
