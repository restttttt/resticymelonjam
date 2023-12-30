using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawnManager : MonoBehaviour
{
    public int NumOfEnemies;
    public GameObject[] EnemiesInScene;
    public GameObject[] spawnPoints;
    public int RandomNum;
    public int RandomNum2;
    public GameObject EnemyPrefab;
    private int i = 0;

    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn Point");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        EnemiesInScene = GameObject.FindGameObjectsWithTag("Enemy");
        RandomNum2 = Random.Range(0,100);
        if (i >= 500)
        {
            Debug.Log("i value 500+");
            if (RandomNum2%2 == 0)
            {
                Spawn();
            }
            else if (EnemiesInScene.Length == 0)
            {
                Spawn();
            }else
            {
                Instantiate(EnemyPrefab, spawnPoints[0].transform.position, Quaternion.identity);
            }
            i = 0;
        }

        i++;
    }

    void Spawn()
    {
        Debug.Log("Spawn func called");
        RandomNum = Random.Range(0,10);

        NumOfEnemies = EnemiesInScene.Length;
        if (NumOfEnemies < 10)
        {
            foreach(GameObject obj in spawnPoints)
            {
                Instantiate(EnemyPrefab, obj.transform.position, Quaternion.identity);
            }
        }
        else if (NumOfEnemies < 15 && RandomNum % 2 == 0)
        {
            foreach(GameObject obj in spawnPoints)
            {
                Instantiate(EnemyPrefab, obj.transform.position, Quaternion.identity);
            }
        }
        else
        {
            Instantiate(EnemyPrefab, spawnPoints[0].transform.position, Quaternion.identity);
        }
    }
}
