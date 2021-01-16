using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
  Image healthBar;  
   float maxHealth = 100f;
  public static float PlayerHealth;
  public GameObject Benson ;
  Animator anim;
  public float delay = 1.5f;
  void Start()
  {
      healthBar = GetComponent<Image>();
      PlayerHealth = maxHealth;
      anim = Benson.GetComponent<Animator>();
     
  }

  private void Update()
  {
      healthBar.fillAmount = PlayerHealth / maxHealth;
      
      if(healthBar.fillAmount <= 0f)
            {
              DeathOfMrBenson();
            Invoke("Restart", delay);
            }
  }

 void DeathOfMrBenson()
  {
   anim.SetBool("die",true);
   anim.SetBool("standing",false);
   SceneManager.LoadScene("GameOver");

  }
  
}
