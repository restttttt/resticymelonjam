using UnityEngine;
using UnityEngine.SceneManagement;

public class talismanSpawnManager1 : MonoBehaviour
{
    public int NumOfTal;
    public GameObject[] TalismansInScene;
    public GameObject[] spawnPoints;
    public int RandomNum;
    public int RandomNum2;
    public GameObject TalismanPrefab;
    private int i = 0;

    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Talisman Spawnpoint");
        TalismansInScene = GameObject.FindGameObjectsWithTag("Talisman");
       
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        TalismansInScene = GameObject.FindGameObjectsWithTag("Talisman");
        RandomNum2 = Random.Range(0,100);
        if (i >= 250)
        {
            Debug.Log("i value 500+");
            if (RandomNum2%2 == 0)
            {
                Spawn();
            }
            else if (TalismansInScene.Length == 0)
            {
                Spawn();
            }else
            {
                Instantiate(TalismanPrefab, spawnPoints[0].transform.position, Quaternion.identity);
            }
            i = 0;
        }

        i++;
    }

    void Spawn()
    {
        Debug.Log("Spawn func called");
        RandomNum = Random.Range(0, 10);

        NumOfTal = TalismansInScene.Length;
        if (NumOfTal < 10 && RandomNum % 2 == 0)
        {
            foreach (GameObject obj in spawnPoints)
            {
                Instantiate(TalismanPrefab, obj.transform.position, Quaternion.identity);
            }
        }
    else if (NumOfTal < 15 && RandomNum % 2 == 0)
    {
        // Adjust the condition or add different logic for this case
        // For example, you might want to spawn a different type of enemy.
        foreach (GameObject obj in spawnPoints)
        {
            Instantiate(TalismanPrefab, obj.transform.position, Quaternion.identity);
        }
    }
    else
    {
        Instantiate(TalismanPrefab, spawnPoints[0].transform.position, Quaternion.identity);
    }

    }
}
