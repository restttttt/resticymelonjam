using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject player;
    public GameObject enemyPrefab;
    public int numberOfEnemies = 8;
    public float respawnTime = 15f;
    public float followSpeed = 5f;

    private void Start()
    {
        SpawnEnemies();
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
        StartCoroutine(FollowPlayer(enemy.transform));
    }

    private Vector3 GetRandomSpawnPoint()
    {
        float spawnRadius = 10f;
        Vector3 playerPosition = player.transform.position;

        float randomAngle = Random.Range(0f, 360f);
        Vector3 spawnDirection = new Vector3(Mathf.Cos(randomAngle), 0, Mathf.Sin(randomAngle));
        Vector3 randomSpawnPoint = playerPosition + spawnDirection * spawnRadius;

        return randomSpawnPoint;
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

    private void RespawnEnemy(GameObject enemy)
    {
        StartCoroutine(RespawnCoroutine(enemy));
    }

    private IEnumerator RespawnCoroutine(GameObject enemy)
    {
        yield return new WaitForSeconds(respawnTime);
        Vector3 randomSpawnPoint = GetRandomSpawnPoint();
        enemy.transform.position = randomSpawnPoint;
        StartCoroutine(FollowPlayer(enemy.transform));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Enemy has been defeated, respawn after a delay
            RespawnEnemy(other.gameObject);
        }
    }
}