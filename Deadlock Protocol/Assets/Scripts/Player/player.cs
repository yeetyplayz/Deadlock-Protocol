using UnityEngine;

public class player : MonoBehaviour
{
    [Header("Player Settings")]
    public float health;
    private float maxHealth;
    public bool isDead;

    [Header("Movement Settings")]
    private Vector3 moveDir;
    private float hor;
    private float vert;
    public float moveSpeed = 4f;
    private Rigidbody rb;
    public float jumpHeight = 7f;
    public bool isGrounded = false;
    
    void Start()
    {
        maxHealth = 200;
        health = maxHealth;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        moveDir.x = hor;
        moveDir.z = vert;
        transform.Translate(moveDir * Time.deltaTime * moveSpeed);
    }
    void FixedUpdate()
    {
        Vector3 moveDir = new Vector3(hor, 0f, vert);
        rb.AddForce(moveDir * moveSpeed, ForceMode.Force);
    }
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        isGrounded = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health < 0)
        {
            Die();
        }
    }
    public void HealHealth(float Heal)
    {
        health += Heal;
    }
    public void Die()
    {
        gameObject.SetActive(false);
        isDead = true;
    }
}
