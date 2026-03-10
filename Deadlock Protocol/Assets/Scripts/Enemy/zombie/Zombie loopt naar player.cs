using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;

    void Update()
    {
        if (player == null) return;

        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}
