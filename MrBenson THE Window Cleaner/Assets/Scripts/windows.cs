using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windows : MonoBehaviour
{
   Animator anim;
   public GameObject window;
   
    // Start is called before the first frame update
    void Start()
    {
     anim =  window.GetComponent<Animator>();     
    } 

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
     if(col.CompareTag("tools"))
     {
       anim.SetBool("closing",true);
	 }
	}
}
