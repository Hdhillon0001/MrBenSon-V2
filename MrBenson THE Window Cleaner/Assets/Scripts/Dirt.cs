using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{
   public  GameObject[] Dirtsprite  ;
    public float Xaxis,Yaxis;
    Vector2 whereToSpawn;
    public static bool spawnAllowed;

    public enum DirtType{ type1,type2,type3}
    public DirtType dirt;
    // Start is called before the first frame update
    void Start()
    {
        
        spawnAllowed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnAllowed)
        {
        if(dirt == DirtType.type1)
        {
          // int randomDirt = Random.Range(o,Dirtsprite.Length);
           whereToSpawn = new Vector2(Xaxis,Yaxis);   
           Instantiate (Dirtsprite[0],whereToSpawn,Quaternion.identity);
           spawnAllowed = false;
		}
        }
        if(spawnAllowed)
        {
        if(dirt == DirtType.type2)
        {
          // int randomDirt = Random.Range(o,Dirtsprite.Length);
           whereToSpawn = new Vector2(Xaxis,Yaxis);   
           Instantiate (Dirtsprite[1],whereToSpawn,Quaternion.identity);
                      spawnAllowed = false;

		}
        }
        if(spawnAllowed)
        {
        if(dirt == DirtType.type3)
        {
          // int randomDirt = Random.Range(o,Dirtsprite.Length);
           whereToSpawn = new Vector2(Xaxis,Yaxis);   
           Instantiate (Dirtsprite[2],whereToSpawn,Quaternion.identity);
                      spawnAllowed = false;

		}
        }
        
        
    }

}
