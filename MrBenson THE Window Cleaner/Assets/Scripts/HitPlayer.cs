using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Method 1
public class HitPlayer : MonoBehaviour
{
 
  public GameObject projectile ;
  public GameObject enemySprite ;
  //public float projectileLifeTime = 2.0f;
  private Rigidbody2D rb;
  Animator anim;
   float time ;
	float current ;

  
   void Start()
    {
            anim = enemySprite.GetComponent<Animator>();
            rb = GetComponent<Rigidbody2D>();

    }
    
 
  void Update()
  {
             current += Time.deltaTime;
		if(current > time)
		{  
		
			  anim.SetBool("enemyThrow",false);
		}
    
 //    if (Input.GetButtonDown("Fire1"))
         // anim.SetBool("Fall",true);
           // Instantiate(projectile, transform.position, Quaternion.identity);
            
	
  }
  
  void OnTriggerEnter2D(Collider2D point )
  {
     

         if(point.gameObject.CompareTag("Player"))
         {    anim.SetBool("enemyThrow",true);
                   time = 1f;
                   current = 0f;
                     Instantiate(projectile, transform.position, Quaternion.identity);
                   

	     }
  }
  
	
		
	



}