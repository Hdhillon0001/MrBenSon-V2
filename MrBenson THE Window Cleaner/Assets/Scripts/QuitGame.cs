using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{  public GameObject particle; 
  public void quit()
   {
		Debug.Log("Quit");
		SceneManager.LoadScene("ui");
	}

	public void  reload()
	{
		SceneManager.LoadScene("version1");
		//    Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.version 1);
	}

	public void start()
	{
		SceneManager.LoadScene("version1");
	}
	 public void feathers()
	 {
	 	 Instantiate(particle,transform.position,Quaternion.identity);
	 }
}
