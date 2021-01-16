using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwaner : MonoBehaviour
{
//private Rigidbody2D Prefab;
       // Animator anim;
public GameObject enemy;
public float randomX = -25.6f;
       float randomY ;
       public float areaTospawn = 10.2f;
Vector2 whereToSpawn;
public float spawnRate = 2f;
float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
           //    anim = GetComponent<Animator>();
             //  Prefab = enemy.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Time.time > nextSpawn)
      {
        nextSpawn = Time.time + spawnRate;
       // randomX = Random.Range(-2.1f,2.1f);
       var yaxis = Random.Range(0f,areaTospawn);//For future Me we can always do modifify Direction for y axis and x axis.
        whereToSpawn = new Vector2(randomX , yaxis );//Instead of randomX transform.position.x);
        Instantiate (enemy, whereToSpawn, Quaternion.identity);
       // anim.SetBool("flying",true);
      }  
    }
}

 