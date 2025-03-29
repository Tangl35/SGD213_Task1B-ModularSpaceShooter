using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeedController : MonoBehaviour
{
    [SerializeField]
    private Vector2 direction;

    [SerializeField]
    private float initialVelocity = 2f;

    private Movement movement;

    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Movement>();
        rb = GetComponent<Rigidbody2D>();

        // Adds velocity to object.
        rb.velocity = direction * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // Calls move function.
        movement.Move(direction);
    }
}
