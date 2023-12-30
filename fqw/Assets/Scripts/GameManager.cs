using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int j = 0;
 
    public GameObject[] Charms;
    public GameObject[] CharmSpawnPoints;


    // Update is called once per frame
    void Start()
    {
        CharmSpawnPoints = GameObject.FindGameObjectsWithTag("Item Spawnpoint");

        
        foreach (GameObject obj in CharmSpawnPoints)
        {
            Debug.Log("Inst 2  " + j);
            if(j>=Charms.Length)
            {
                j = 0;
            }
            Instantiate(Charms[j], obj.gameObject.transform.position, Quaternion.identity);
            j++;
        }
    }
}
