using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public Transform PlayerPos;
    public NavMeshAgent enemy;

    void Update()
    {
        enemy.SetDestination(PlayerPos.position);
    }
}
