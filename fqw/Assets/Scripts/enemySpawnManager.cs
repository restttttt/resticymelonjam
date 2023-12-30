using UnityEngine;
using UnityEngine.SceneManagement;

public class enemySpawnManager : MonoBehaviour
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
        EnemiesInScene = GameObject.FindGameObjectsWithTag("Enemy");
        Spawn();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        EnemiesInScene = GameObject.FindGameObjectsWithTag("Enemy");
        RandomNum2 = Random.Range(0,100);
        if (i >= 250)
        {
            Debug.Log("i value 250+");
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
        RandomNum = Random.Range(0, 10);

        NumOfEnemies = EnemiesInScene.Length;
        if (NumOfEnemies < 10 && RandomNum % 2 == 0)
        {
            foreach (GameObject obj in spawnPoints)
            {
                Instantiate(EnemyPrefab, obj.transform.position, Quaternion.identity);
            }
        }
    else if (NumOfEnemies < 15 && RandomNum % 2 == 0)
    {
        // Adjust the condition or add different logic for this case
        // For example, you might want to spawn a different type of enemy.
        foreach (GameObject obj in spawnPoints)
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
