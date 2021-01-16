using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Method 1
public class EnemyMove : MonoBehaviour
{
  public float speed;
  public bool MoveRight;
  public GameObject projectile ;
  float time ;
	float current ;
    float PlayerDamage = 100f;


  //public float projectileLifeTime = 2.0f;
 private Rigidbody2D rb;
  Animator anim;


   void Start()
    {
            anim = GetComponent<Animator>();
            rb = GetComponent<Rigidbody2D>();

    }
    
 
  void Update()
  {
      
          current += Time.deltaTime;
		if(current > time)
		{  
		
			  anim.SetBool("enemyKill",false);
		}
      if(MoveRight)
      {
      transform.Translate(2*speed*Time.deltaTime,0,0);
      transform.localScale = new Vector2(-1,1);
      
      }
      else
    
    {
      transform.Translate(-2*speed*Time.deltaTime,0,0);
	  transform.localScale = new Vector2(1,1);  
    }

	
  
}
  void OnTriggerEnter2D(Collider2D point )
  {
      if(point.gameObject.CompareTag("EnemyFollowePoint"))
         {
           if(MoveRight)
           {
            MoveRight = false;
	       }
           else
           {
            MoveRight = true;
	        }
	     }

         if(point.gameObject.CompareTag("Player"))
         {           anim.SetBool("enemyKill",true);
                     time = 1f;
                     current = 0f;
                     Instantiate(projectile, transform.position, Quaternion.identity);
                     HealthDamage();
	     }
  }

      void HealthDamage()
    {
        Health.PlayerHealth -= PlayerDamage;
	}
  

}
/*

CapsuleCollider bodyCollider; //OR BoxCollider bodyCollider;
SphereCollider headCollider;

void Start () 
{
    bodyCollider = desiredGameObject.GetComponent<CapsuleCollider> (); //OR bodyCollider = gameObject.GetComponent<BoxCollider> ();
    headCollider = desiredGameObject.GetComponent<SphereCollider> ();
}

void OnTriggerEnter (Collider other)
{
    if (other == bodyCollider)
    {
        //This happens when the body is hit
    }
    if (other == headCollider)
    {
        //This happens when the head is hit
    }
}
//Method 2
public class EnemyMove : MonoBehaviour
{
    Rigidbody2D enemyRigidBody2D;
    public int UnitsToMove = 5;
    public float EnemySpeed = 500;
    public bool _isFacingRight;
    private float _startPos;
    private float _endPos;

    public bool _moveRight = true;


    // Use this for initialization
    public void Awake()
    {
         enemyRigidBody2D = GetComponent<Rigidbody2D>();
        _startPos = transform.position.x;
        _endPos = _startPos + UnitsToMove;
        _isFacingRight = transform.localScale.x > 0;
    }


// Update is called once per frame
public void Update()
{

    if (_moveRight)
    {
        enemyRigidBody2D.AddForce(Vector2.right * EnemySpeed * Time.deltaTime);
        if (!_isFacingRight)
            Flip();
    }

    if (enemyRigidBody2D.position.x >= _endPos)
        _moveRight = false;

    if (!_moveRight)
    {
        enemyRigidBody2D.AddForce(-Vector2.right * EnemySpeed * Time.deltaTime);
        if (_isFacingRight)
            Flip();
    }
    if (enemyRigidBody2D.position.x <= _startPos)
        _moveRight = true;


}

    public void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        _isFacingRight = transform.localScale.x > 0;
    }

}*/

/*
Method 3


public class EnemyMove : MonoBehaviour
{

    Rigidbody2D Enemy;
    public int UnitToMove ;
    public float EnemySpeed  ;
    public bool _isFacingRight;
    public float _startPos;
    public float _endPos;

    public bool _isMovingRight = true;

    public void Awake()
    {
     Enemy = GetComponent<Rigidbody2D>();
     _startPos = transform.position.x;
     _endPos = _startPos + UnitToMove;
     _isFacingRight = transform.localScale.x > 0;
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isMovingRight)
        {
          Enemy.AddForce(Vector2.right * EnemySpeed * Time.deltaTime);
              if(!_isMovingRight)
                  {
             //      flip();        
				  }
		}

        if (Enemy.position.x > _endPos)
        {
           _isMovingRight = false;  
		}

        if (!_isMovingRight)
        {
           Enemy.AddForce(-Vector2.right * EnemySpeed * Time.deltaTime);
              if(_isFacingRight)
                  {
           //        flip();        
				  } 
		}
        
        if (Enemy.position.x <= _startPos)
        {
           _isMovingRight = true;  
		}
    }


    public void flip()
        {
          transform.localScale = new Vector3(-transform.localScale.x,transform.localScale.y,transform.localScale.z);
          _isFacingRight = transform.localScale.x > 0;
        }
}

*/