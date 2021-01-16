using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGround : MonoBehaviour
{
 

    
     void OnCollisionEnter(Collision collision)
 {
         if (collision.gameObject.tag == "Player")
         {
             Physics.IgnoreLayerCollision(8, 9);
         }
       }
}
