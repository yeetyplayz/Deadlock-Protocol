using UnityEngine;

using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    private Transform player;
    public float speed = 3f;
    public float rotationSpeed = 5f;

    void Start()
    {
        // Krijg automatisch de speler via GameManager
        if (GameManager.Instance != null)
        {
            player = GameManager.Instance.player;
        }
        else
        {
            Debug.LogError("GameManager niet gevonden!");
        }
    }

    void Update()
    {
        if (player == null) return;

        // Beweeg elke frame naar huidige positie van player
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        // Draai naar speler (smooth)
        if (direction != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);
        }
    }
}