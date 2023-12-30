using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    public Transform PlayerPos;
    public NavMeshAgent enemyAI;
    public int EnemyHealth = 20;
    public bool hit = false;
    public AxeAttack axe;
    
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
    void OnTriggerEnter(UnityEngine.Collider other)
    {
        
        Debug.Log("DMG");
        if (other.gameObject.CompareTag("weapon"))
        {

            EnemyHealth -= other.gameObject.GetComponent<AxeAttack>().AxeDamage;
            hit = true;
            Instantiate(axe.bloodVFX, axe.bloodpos.transform.position, axe.transform.rotation);
        }else if (other.gameObject.CompareTag("Polaroid"))
        {
            EnemyHealth -= other.gameObject.GetComponent<PolaroidAttack>().PolaroidDmg;
            hit = true;
        }
    }
}
