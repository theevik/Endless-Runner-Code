using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{


    public GameObject enviroment;
    public GameObject enviroment1;
    public GameObject enviroment2;
    public GameObject enviroment3;
    public GameObject enviroment4;

    public GameObject player;
     
     

    float chance;

    
    void OnTriggerEnter(Collider other)
    {
       /*This script is attached to each spawnable block of walls. Each of them has an invisible cube that acts as a trigger.
        * Once the player enters, a random prefab will spawn will spawn. It is easy to add and remove different types of enviroments and
        * challenges into the game with this method.
        */
        chance = Random.Range(1f, 100f);

        

        if (chance >= 1 && chance <= 20)
        {
            Instantiate(enviroment, new Vector3(0, 0, player.transform.position.z + 60), Quaternion.identity);
        }
        else if (chance >= 21 && chance <= 40)
        {
            Instantiate(enviroment1, new Vector3(0, 0, player.transform.position.z + 60), Quaternion.identity);
        }
        else if (chance >= 41 && chance <= 60)
        {
            Instantiate(enviroment2, new Vector3(0, 0, player.transform.position.z + 60), Quaternion.identity);
        }
        else if (chance >= 61 && chance <= 80)
        {
            Instantiate(enviroment3, new Vector3(0, 0, player.transform.position.z + 60), Quaternion.identity);
        }
        else  
        {
            Instantiate(enviroment4, new Vector3(0, 0, player.transform.position.z + 60), Quaternion.identity);
        }
       

        
    }
}
