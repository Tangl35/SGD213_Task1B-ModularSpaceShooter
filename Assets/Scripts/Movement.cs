using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    // Variable for player speed
    [SerializeField]
    public float speed = 75f;

    private Rigidbody2D rb;

    // Start is called before the first frame update.
    void Start()
    {
        // Get Rigidbody Component for player.
        rb = GetComponent<Rigidbody2D>();
    }

    // Player movement on horizontal axes.
    public void Move(Vector2 direction)
    {
        // Add movement to rigidbody.
        rb.AddForce(direction * speed * Time.deltaTime);

    }
}
