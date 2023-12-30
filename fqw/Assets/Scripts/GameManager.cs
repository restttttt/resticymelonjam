using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int i = 0;
    public int j = 0;
    public GameObject[] TalismanPrefabs;
    public GameObject[] Charms;
    public GameObject[] CharmSpawnPoints;
    public GameObject[] TalismanSpawnPoints;

    // Update is called once per frame
    void Start()
    {
        TalismanSpawnPoints = GameObject.FindGameObjectsWithTag("Talisman Spawnpoint");
        CharmSpawnPoints = GameObject.FindGameObjectsWithTag("Item Spawnpoint");

        foreach(GameObject obj in TalismanPrefabs)
        {
            Debug.Log("Inst 1  " + i);
            Instantiate(obj, TalismanSpawnPoints[i].transform.position, Quaternion.identity);
            i++;
        }
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
    public void Respawn()
    {
        SceneManager.LoadScene(0);
    }
}
