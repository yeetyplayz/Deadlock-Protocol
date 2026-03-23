using UnityEngine;

public class oOB : MonoBehaviour
{
    public ZombieHealth zHealth;
    public player pHealth;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Player"))
        {
            pHealth = GetComponent<player>();
            pHealth.Die();
        }
        if(other.transform.CompareTag("Zombie"))
        {
            zHealth = GetComponent<ZombieHealth>();
            zHealth.Die();
        }
    }
}
