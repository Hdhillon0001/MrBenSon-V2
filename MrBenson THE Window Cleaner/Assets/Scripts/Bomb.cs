using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
   Animator anim ;
   float current;
   public float time;
   public float Destroytime;
   float PlayerDamage = 40f;
  // public GameObject ObjectToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
          
    }
    void OnTriggerEnter2D(Collider2D col)
    {
      if(col.gameObject.CompareTag("Player"))
      {
          anim.SetBool("fire",true);
          
        
          
             Invoke("changeAnimation",time);
                
	  }


	}
    void changeAnimation()
    {
            anim.SetBool("fire",false);
            anim.SetBool("blast",true);
            Invoke("DestroyBomb",Destroytime);
             HealthDamage();
	}
  
    void DestroyBomb()
    { 
      
       Destroy(this.gameObject);
	}
    
      void HealthDamage()
    {
        Health.PlayerHealth -= PlayerDamage;
	}
  
}
