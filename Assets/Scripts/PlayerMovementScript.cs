using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{
    // Variable for player speed
    [SerializeField]
    private float speed = 5000f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Get Rigidbody Component for player
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f)
        {
            Vector2 ForceToAdd=Vector2.right*HorizontalInput*speed*Time.deltaTime;
            rb.AddForce(ForceToAdd);
        }
    }
}
