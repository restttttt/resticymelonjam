using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    public Transform PlayerPos;
    public NavMeshAgent enemyAI;
    public int EnemyHealth = 10;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPos = GameObject.FindGameObjectWithTag("Player").transform;
        enemyAI = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyAI.SetDestination(PlayerPos.position);
        if(EnemyHealth == 0)
        {
            Destroy(gameObject);
        }
    }
}