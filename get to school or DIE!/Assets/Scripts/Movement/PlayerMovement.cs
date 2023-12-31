using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isJumping = false;
    private Rigidbody2D rb;
    public GameObject DebugText;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Horizontal movement
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Jumping
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }



        //debug

        if (Input.GetButtonDown("Debug"))
        {
            //rb.velocity = new Vector2(rb.velocity.x, jh);
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            debugMode();

            Debug.Log("Cheat debug mode activated");




        }

        void debugMode()
        {

            DebugText.SetActive(true);


        }

        //debug











    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Reset jumping state when touching the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;

        }


        
    }


}
