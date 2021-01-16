using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public GameObject Particle;
    private Rigidbody2D rb;
        Animator anim;
    //public bool sound ;

   public enum choice{ Vertical,Horizontal}
   public choice Direction;
    // Start is called before the first frame update
    void Start()
    {
            anim = GetComponent<Animator>();
               rb = GetComponent<Rigidbody2D>();

    }



    // Update is called once per frame
    void Update()
    {
        if(Direction == choice.Vertical){
        
         transform.Translate(Vector2.down*speed*Time.deltaTime);
           anim.SetBool("Fall",true);
         }
          
        if(Direction == choice.Horizontal){
        
         transform.Translate(Vector2.right*speed*Time.deltaTime);
      //   SoundManager.PlaySound ("birdFlying");
            
                 
                //   anim.SetBool("flying",true);
                   
         }
         
     

    }
    void OnTriggerEnter2D(Collider2D GarbageBag )
    {

           if(GarbageBag.CompareTag("Player"))
       {
      
        { anim.SetTrigger("hurt");}
         DestroyProjectile();
        //  sound = true;

	   }

       
      /*   if(sound ){
       SoundManager.PlaySound ("birdHurt");  
		 sound = false;
         }*/
    }
    void DestroyProjectile()
    {
     //    anim.SetBool("flying",false);
      
     Instantiate(Particle,transform.position,Quaternion.identity);
    // Destroy(gameObject);
    // Destroy(Particle);
     
	}
   

}
