using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    private Vector3 moveDir;
    private float hor;
    private float vert;
    public float moveSpeed = 4f;
    private Rigidbody rb;
    public float jumpHeight = 7f;
    private bool isGrounded = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (isGrounded = true && Input.GetKeyDown(KeyCode.Space))
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
}