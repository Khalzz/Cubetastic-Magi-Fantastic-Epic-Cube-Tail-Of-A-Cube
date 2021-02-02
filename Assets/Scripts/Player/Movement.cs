using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    //others
    private Rigidbody2D rb;
    public float velocity;
    public float jumpForce; 
    public bool itsInTheFloor;
    
    ///muerte
    public Transform deathPosition;
    public bool itsDead;
    public LayerMask whatIsDeath;
    public float footDeathRadio;

    //ganaste
    public bool youWin;
    public LayerMask whatIsWin;

    //floor
    public float footRadio; 
    public Transform footPosition;
    public LayerMask whatIsFloor; 
    
    private float jumpCount;
    public float jumpTime; //0.2
    private bool itsJumping;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical"); 
        Vector2 direction = new Vector2(x, y); 

        Walk(direction);

        itsInTheFloor = Physics2D.OverlapCircle(footPosition.position,footRadio,whatIsFloor);
        itsDead = Physics2D.OverlapCircle(deathPosition.position,footDeathRadio,whatIsDeath);

        if (Input.GetAxisRaw("Run")>0)
        {
            velocity = 35;
        }
        else
        {
            velocity = 20;
        }

        if (itsInTheFloor == true && Input.GetButton("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            itsJumping = true;
	        jumpCount = jumpTime;
        } 
        else
        {
            itsInTheFloor = false;
        }
        

        if (Input.GetButton("Jump") && itsJumping == true)
        {
            if (jumpCount > 0)
            {
               rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
               jumpCount -= Time.deltaTime;
            }
            else 
            {
                itsJumping = false;
            }   
        }
        
        if (Input.GetButtonUp("Jump"))
        {
            itsJumping = false;
        }
    }

    private void Walk(Vector2 direction)
    {
        rb.velocity = (new Vector2(direction.x * velocity, rb.velocity.y));
    }
}
