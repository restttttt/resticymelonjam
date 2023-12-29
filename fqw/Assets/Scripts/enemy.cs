using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public DamageArea Dam;
    public GameObject player;
    public GameObject enemyPrefab;
    public int numberOfEnemies = 8;
    public float respawnTime = 15f;
    public float followSpeed = 5f;
    public float minDistanceBetweenEnemies = 3f;

    public float timerrespawn;
    public bool respawn = false;

    private List<Transform> spawnedEnemies = new List<Transform>();

    private void Start()
    {
        SpawnEnemies();
    }
    

    //respawn
    public void Update()
    {
        if (Dam.defeated)
    {
        
        timerrespawn = 5f;
    }

    if (timerrespawn > 0)
    {
        timerrespawn -= 1f * Time.deltaTime;
        respawn = true;
    }

    if (respawn && timerrespawn <= 0)
    {
        SpawnEnemies();
        respawn = false;
    }

    }

    private void SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        Vector3 randomSpawnPoint = GetRandomSpawnPoint();
        GameObject enemy = Instantiate(enemyPrefab, randomSpawnPoint, Quaternion.identity);
        spawnedEnemies.Add(enemy.transform);
        StartCoroutine(FollowPlayer(enemy.transform));
    }

    private Vector3 GetRandomSpawnPoint()
    {
        float spawnRadius = 10f;
        Vector3 playerPosition = player.transform.position;

        float randomAngle = Random.Range(0f, 360f);
        Vector3 spawnDirection = new Vector3(Mathf.Cos(randomAngle), 0, Mathf.Sin(randomAngle));
        Vector3 randomSpawnPoint = playerPosition + spawnDirection * spawnRadius;

        // Ensure the new spawn point is not too close to existing enemies
        while (IsTooCloseToOtherEnemies(randomSpawnPoint))
        {
            randomAngle = Random.Range(0f, 360f);
            spawnDirection = new Vector3(Mathf.Cos(randomAngle), 0, Mathf.Sin(randomAngle));
            randomSpawnPoint = playerPosition + spawnDirection * spawnRadius;
        }

        return randomSpawnPoint;
    }

    private bool IsTooCloseToOtherEnemies(Vector3 point)
    {
        foreach (Transform enemyTransform in spawnedEnemies)
        {
            if (Vector3.Distance(point, enemyTransform.position) < minDistanceBetweenEnemies)
            {
                return true;
            }
        }
        return false;
    }

    private IEnumerator FollowPlayer(Transform enemyTransform)
    {
        while (true)
        {
            if (player != null)
            {
                Vector3 direction = (player.transform.position - enemyTransform.position).normalized;
                enemyTransform.Translate(direction * followSpeed * Time.deltaTime);
            }
            yield return null;
        }
    }

   
}