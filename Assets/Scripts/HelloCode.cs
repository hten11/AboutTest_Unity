using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HelloCode : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello, World!");
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get input from the user
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a new vector for movement
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply the movement to the player's Rigidbody
        playerRigidbody.AddForce(movement * speed);
    }
}
