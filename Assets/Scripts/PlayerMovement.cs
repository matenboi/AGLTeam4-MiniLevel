using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    private Rigidbody2D body;

    // Is called when script instance is loaded
    private void Awake()
    {
        // Script will check the Player Object has as RigidBody2D
        body = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // Left and Right inputs ONLY
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, body.velocity.y);

        // Uses whatever unity has set as "Jump" as the input GEtIn
        if (Input.GetButtonDown("Jump"))
        {
            body.velocity = new Vector2(body.velocity.x, jumpForce);
        }

        /*
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            body.velocity = new Vector2(body.velocity.x, -jumpForce);
        }
        */
    }
}
