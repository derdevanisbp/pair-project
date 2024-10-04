using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Movement speed
    public float jumpForce = 10f; // Force applied for jumping
    public int maxJumpCount = 2; // Maximum number of jumps

    private Rigidbody2D rb;
    private int jumpCount; // Current number of jumps left
    private bool isGrounded; // To check if player is on the ground

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpCount = maxJumpCount; // Initialize jump count
    }

    void Update()
    {
        // Movement input
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

        // Check if player is on the ground
        isGrounded = CheckIfGrounded();

        // Jumping input
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isGrounded || jumpCount > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                if (!isGrounded)
                {
                    jumpCount--; // Decrease jump count if not grounded
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player is touching the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpCount = maxJumpCount; // Reset jump count when grounded
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Check if player is leaving the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private bool CheckIfGrounded()
    {
        // Simple ground check; can be replaced with a more robust method if needed
        // For example, using a Physics2D.OverlapCircle or similar approach
        return isGrounded;
    }
}


