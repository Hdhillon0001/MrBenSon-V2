﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{ //Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       // anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
       if(col.CompareTag("Player")){
       
       Destroy(this.gameObject);

       Health.PlayerHealth += 30f; 

	   }
    }
}
