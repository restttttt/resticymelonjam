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
    public AudioSource Slash;
    public GameObject Death;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPos = GameObject.FindGameObjectWithTag("Player").transform;
        enemyAI = gameObject.GetComponent<NavMeshAgent>();
        Death = GameObject.FindGameObjectWithTag("deathsfx");
    }

    // Update is called once per frame
    void Update()
    {
        enemyAI.SetDestination(PlayerPos.position);
        if(EnemyHealth == 0)
        {
            Death.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("DMG");
        if (other.gameObject.CompareTag("weapon"))
        {
            Slash.Play();
            EnemyHealth -= other.gameObject.GetComponent<AxeAttack>().AxeDamage;
            hit = true;
            Instantiate(axe.bloodVFX, axe.bloodpos.transform.position, axe.transform.rotation);
        }else if (other.gameObject.CompareTag("Polaroid"))
        {
            Slash.Play();
            EnemyHealth -= other.gameObject.GetComponent<PolaroidAttack>().PolaroidDmg;
            hit = true;
        }
    }
}
