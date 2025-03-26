﻿using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;

    private float lastFiredTime = 0f;

    [SerializeField]
    private float fireDelay = 1f;

    private float bulletOffset = 2f;

    void Start()
    {
        // Spawn bullet in front of player and define its size.
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 + bullet.GetComponent<Renderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            float CurrentTime = Time.time;

            // Delay shots fired.
            if (CurrentTime - lastFiredTime > fireDelay)
            {
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);

                Instantiate(bullet, spawnPosition, transform.rotation);

                lastFiredTime = CurrentTime;
            }
        }
    }

    // Converts integer to a float and returns float.
    public float SampleMethod(int number)
    {
        return number;
    }

}
