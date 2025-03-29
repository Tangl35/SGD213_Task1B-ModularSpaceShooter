using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Movement movement;
    private ShootingScript shootingScript;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Movement>();
        shootingScript = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        // Move player.
        movement.Move(Vector2.right * input);

        // Shoot bullet.
        if (Input.GetButton("Fire1"))
        {
            if (shootingScript != null)
            {
                shootingScript.Shoot();
            }

            else
            {
                Debug.Log("Attach the ShootingScript");
            }
        }
    }
}
