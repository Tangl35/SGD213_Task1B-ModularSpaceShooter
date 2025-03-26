using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{
    // Variable for player speed
    public float speed = 5000f;

    private Rigidbody2D rb;

    // Start is called before the first frame update.
    void Start()
    {
        // Get Rigidbody Component for player.
        rb = GetComponent<Rigidbody2D>();
    }

    // Player movement on horizontal axes.
    public void HorizontalMovement(float HorizontalInput)
    {
        Vector2 ForceToAdd = Vector2.right * HorizontalInput * speed * Time.deltaTime;
        rb.AddForce(ForceToAdd);
    }
}
