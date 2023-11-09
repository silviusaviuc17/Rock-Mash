using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    public float jumpForce = 10.0f;
    public float moveSpeed = 5.0f;
    public Rigidbody2D rb;
    public float minYLevel = 4.5f;
    public LogicScript1 logic;
    public bool playerIsAlive = true;
    public AudioSource audioSource;


    void Start()
    {
        
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript1>();
       
         rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check for player input to jump
        if (Input.GetKeyDown(KeyCode.Space) && playerIsAlive )
        {
            Jump();
        }
      // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Check if the AudioSource component is assigned
            if (audioSource != null)
            {
                // Play the audio clip
                audioSource.Play();
            }
        }
    }

    void FixedUpdate()
    {
        // Move the character horizontally
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
    }

    void Jump()
    {
        // Check if the character is grounded before jumping
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
        if (hit.collider != null)
        {
            // Apply an upward force to jump
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision){
        
   
    // Check if the collision is with a specific GameObject by tag
    //if (collision.gameObject.CompareTag("Rock"))
    //{
       // Debug.Log("Game Over triggered!");
        //logic.gameOver();
        //playerIsAlive = false;
    //}
    //}
}


