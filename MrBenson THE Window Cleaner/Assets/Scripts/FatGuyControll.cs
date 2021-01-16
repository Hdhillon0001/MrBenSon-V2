using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatGuyControll : MonoBehaviour {

    Rigidbody2D rb;
    float dirX;
    public float jumpForce = 500f, moveSpeed = 5f;
    float time ;
	float current ;
       //static AudioSource audioSrc;
       //  public static AudioClip playerWalking;
    
    int playerLayer, groundLayer;
    Animator anim  ;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D> ();
        playerLayer = LayerMask.NameToLayer ("Player");
        groundLayer = LayerMask.NameToLayer ("Ground");
        anim = GetComponent<Animator>();
      //  playerWalking = Resources.Load<AudioClip>("playerWalking");

       
    }
    
    // Update is called once per frame
    void Update () {
     
          current += Time.deltaTime;
		if(current > time)
		{  
		
			  anim.SetBool("fixing",false);
		}
       dirX = Input.GetAxis ("Horizontal");
        //	Physics2D.IgnoreLayerCollision(playerLayer, Player, true);
        if (Input.GetButtonDown ("Jump"))
            rb.AddForce (Vector2.up * jumpForce, ForceMode2D.Force);
        if(rb.velocity.x!=0 )
        {
            anim.SetBool("walking",true);
            anim.SetBool("fixing",false);
           // audioSrc.PlaySound ("playerWalking");
        }
        else{anim.SetBool("walking",false); }
        if (rb.velocity.y > 0)
            {
            Physics2D.IgnoreLayerCollision(playerLayer, groundLayer, true);
            anim.SetBool("jump",true);}
        else{
            Physics2D.IgnoreLayerCollision(playerLayer, groundLayer, false);
             anim.SetBool("jump",false);			
            }
            if(rb.velocity.y == 0)
            {
                anim.SetBool("falling",false);
            }
        if(Input.GetButton("fix"))
        {
            anim.SetBool("fixing",true);
            current = 0;
            time = 0.5f;
        }
    
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2 (dirX * moveSpeed, rb.velocity.y);
    }

}
