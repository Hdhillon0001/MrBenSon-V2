using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BensonController : MonoBehaviour
{ 



    private bool grounded;
    public float MoveSpeed = 5; 
    public float jumpForce = 30;
    private Rigidbody2D body;
    private float moveInput;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
   // public GameObject projectile ;
  

      void Start()
   {
           body = GetComponent<Rigidbody2D>();
           Physics.IgnoreLayerCollision(8, 9);
   }


    void FixedUpdate()
    
    {

  // if( Input.GetKey(KeyCode.DownArrow))
    //{

     // RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);

        // If it hits something...
       // if(hit.point.y <= transform.position.y)
      //  {
            // Calculate the distance from the surface and the "error" relative
            // to the floating height.
          //  float distance = Mathf.Abs(hit.point.y - transform.position.y);
          //  float heightError = floatHeight - distance;

            // The force is proportional to the height error, but we remove a part of it
            // according to the object's speed.
           // float force = liftForce * heightError - body.velocity.y * damping;

            // Apply the force to the rigidbody.
     //transform.Translate(Vector2.down*MoveSpeed*Time.deltaTime);
        //}
        
	if( Input.GetKey(KeyCode.UpArrow))
    {
     transform.Translate(Vector2.up*jumpForce*Time.deltaTime);
	}
    
    if(Input.GetKey(KeyCode.LeftArrow))
    {
    transform.Translate(Vector2.left*MoveSpeed*Time.deltaTime);
	}
	if(Input.GetKey(KeyCode.RightArrow))
    {
     transform.Translate(Vector2.right*MoveSpeed*Time.deltaTime);
	}

   }

    void Update()
    {
          
    }
   
	

  /*  private void CheckGrounded()
    {
   
    {
      grounded =  body.velocity.y == 0.0f;
    public float floatHeight;     // Desired floating height.
    public float liftForce;       // Force to apply when lifting the rigidbody.
    public float damping;         // Force reduction proportional to speed (reduces bouncing).

   // Cast a ray straight down.
     
     // If it hits something...
     if (hit != null) 
     {
         grounded = true;
     }
    }
    */

    /*
    method2 
    
      private bool isGrounded;
    public float MoveSpeed; 
    public float jumpForce ;
    private Rigidbody2D body;
    private float moveInput;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;
   // public GameObject projectile ;
  

      void Start()
   {
           body = GetComponent<Rigidbody2D>();

   }


    void FixedUpdate()
    
    {

     moveInput = Input.GetAxisRaw("Horizontal");
     body.velocity = new Vector2(moveInput * MoveSpeed, body.velocity.y);

     }

    void update()
       {
         isGrounded = Physics2D.OverlapCircle(feetPos.position,checkRadius,whatIsGround)
         if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
                {
                     isJumping = true;
                     jumpTimeCounter = jumpTime;
                     body.velocity = Vector2.up * jumpForce;
                }

                  if(Input.GetKeyDown(KeyCode.Space) && isJumping == true)
                      {
                      Debug.Log("works");
                             if(jumpTimeCounter > 0)
                                     {
                                          body.velocity = Vector2.up * jumpForce;
                                          jumpTimeCounter -= Time.deltaTime;
	                                 }
                               else
                                       {
                                            isJumping = false;
                                    	}
                      }
                  if(Input.GetKeyUp(KeyCode.Space))
                      {
                            isJumping = false;
                      }
          
             }
   
	}*/

     
} 