using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{	//Animator anim;
	public float time = 0f;
	float current = 0f;
		void Start()
		{
		//	anim = GetComponent<Animator>();
		}
	void Update () {
		current += Time.deltaTime;
		if(current > time)
		{  
		//anim.SetBool("enemyThrow",false);
			Destroy(this.gameObject);
		}
	}
}
