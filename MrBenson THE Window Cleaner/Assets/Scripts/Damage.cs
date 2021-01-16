using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
public float PlayerDamage = 0.0f;



    private void OnTriggerEnter2D(Collider2D hit )
    {
            if(hit.CompareTag("Player"))
            { 
                    HealthDamage();
                    
            }
    }

    void HealthDamage()
    {
        Health.PlayerHealth -= PlayerDamage;
	}
/*
  private float GarbageDamage;
// private  health HealthController;

 private void OnTriggerEnter2D(Collider2D collision)
 {
    if(collision.CompareTag("Player"))
    {
      DamageMade();
	}
 }

 void DamageMade()
 {
     HealthController.playerHealth = HealthController.playerHealth - GarbageDamage;
      HealthController.UpdateHealth();
      this.gameObject.SetActive(false);
 }
}
*/
}