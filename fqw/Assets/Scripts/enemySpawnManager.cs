using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class enemySpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject[] spawnPoints;
    public GameObject[] enemiesInScene;
    public int randNum = Random.Range(0,10);    

    // Update is called once per frame
    void Update()
    {
        enemiesInScene = GameObject.FindGameObjectsWithTag("Enemy");
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn Points");
        


    }
}
