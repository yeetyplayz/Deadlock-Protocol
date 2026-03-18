using UnityEngine;

public class jumpPad : MonoBehaviour
{
    private Rigidbody rb;
    private int jumpForce = 15;
    public player player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb = other.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            player.isGrounded = false;
        }
    }
}
