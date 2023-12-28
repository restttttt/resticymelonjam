using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public DamageArea Dam;
    public NavMeshAgent Enemy1;
    public NavMeshAgent Enemy2;
    public NavMeshAgent Enemy3;
    public NavMeshAgent Enemy4;
    public NavMeshAgent Enemy5;
    public NavMeshAgent Enemy6;
    public NavMeshAgent Enemy7;
    public NavMeshAgent Enemy8;
    public Transform Player;
    public GameObject enemyobj1;
    public GameObject enemyobj2;
    public GameObject enemyobj3;
    public GameObject enemyobj4;
    public GameObject enemyobj5;
    public GameObject enemyobj6;
    public GameObject enemyobj7;
    public GameObject enemyobj8;
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;
    public Transform pos5;
    public Transform pos6;
    public Transform pos7;
    public Transform pos8;
    public bool follow1 = false;
    public bool follow2 = false;
    public bool follow3 = false;
    public bool follow4 = false;
    public bool follow5 = false;
    public bool follow6 = false;
    public bool follow7 = false;
    public bool follow8 = false;
    public float foltim1 = 1f;
    public float foltim2 = 1f;
    public float foltim3 = 1f;
    public float foltim4 = 1f;
    public float foltim5 = 1f;
    public float foltim6 = 1f;
    public float foltim7 = 1f;
    public float foltim8 = 1f;

    // Start is called before the first frame update
    void Start()
    {
        enemyobj1.transform.position = pos1.position;
        enemyobj2.transform.position = pos2.position;
        enemyobj3.transform.position = pos3.position;
        enemyobj4.transform.position = pos4.position;
        enemyobj5.transform.position = pos5.position;
        enemyobj6.transform.position = pos6.position;
        enemyobj7.transform.position = pos7.position;
        enemyobj8.transform.position = pos8.position;
    }

    // Update is called once per frame
    void Update()
    {

        if(Dam.hit1 == true)
        {
            Dam.hit21 = true;
            
        }
        if(Dam.hit21 == true)
        {
            Dam.respawn1 -= 1f * Time.deltaTime;
            foltim1 = 1f;
            
            
        }
        if(Dam.respawn1 <= 0 && follow1 == true)
        {
            enemyobj1.SetActive(true);
            RSP1();
            foltim1 -= 1f * Time.deltaTime;

        }
        if(foltim1 <= 0)
        {
            follow1 = false;
            Enemy1.SetDestination(Player.position);
        }

        if(Dam.hit2 == true)
        {
            Dam.hit22 = true;
            
            
        }
        if(Dam.hit22 == true)
        {
            Dam.respawn2 -= 1f * Time.deltaTime;
            foltim2 = 1f;foltim2 = 1f;
        }
        if(Dam.respawn2 <= 0 && follow2 == true)
        {
            enemyobj2.SetActive(true);
            RSP2();
            foltim2 -= 1f * Time.deltaTime;
        }
        if(foltim2 <= 0)
        {
            follow2 = false;
            Enemy2.SetDestination(Player.position);
        }

        if(Dam.hit3 == true)
        {
            Dam.hit23 = true;
            
        }
        if(Dam.hit23 == true)
        {
            Dam.respawn3 -= 1f * Time.deltaTime;
            foltim3 = 1f;
        }
        if(Dam.respawn3 <= 0 && follow3 == true)
        {
            enemyobj3.SetActive(true);
            RSP3();
            foltim3 -= 1f * Time.deltaTime;
        }

        if(foltim3 <= 0)
        {
            follow3 = false;
            Enemy3.SetDestination(Player.position);
        }

        if(Dam.hit4 == true)
        {
            Dam.hit24 = true;
            
        }
         if(Dam.hit24 == true)
         {
            Dam.respawn4 -= 1f * Time.deltaTime;
            foltim4 = 1f;
         }
        if(Dam.respawn4 <= 0 && follow4 == true)
        {
            enemyobj4.SetActive(true);
            RSP4();
            foltim4 -= 1f * Time.deltaTime;
        }

        if(foltim4 <= 0)
        {
            follow4 = false;
            Enemy4.SetDestination(Player.position);
        }

        if(Dam.hit5 == true)
        {
            Dam.hit25 = true;
            
        }
        if(Dam.hit25 == true)
        {
            Dam.respawn5 -= 1f * Time.deltaTime;
            foltim5 = 1f;
        }
        if(Dam.respawn5 <= 0 && follow5 == true)
        {
            enemyobj5.SetActive(true);
            RSP5();
            foltim5 -= 1f * Time.deltaTime;
        }
        if(foltim5 <= 0)
        {
            follow5 = false;
            Enemy5.SetDestination(Player.position);
        }

        if(Dam.hit6 == true)
        {
            Dam.hit26 = true;
            
        }
        if(Dam.hit26 == true)
        {
            Dam.respawn6 -= 1f * Time.deltaTime;
            foltim6 = 1f;
        }
        if(Dam.respawn6 <= 0 && follow6 == true)
        {
            enemyobj6.SetActive(true);
            RSP6();
            foltim6 -= 1f * Time.deltaTime;
        }
        if(foltim6 <= 0)
        {
            follow6 = false;
            Enemy6.SetDestination(Player.position);
        }

        if(Dam.hit7 == true)
        {
             Dam.hit27 = true;
            
        }
        if(Dam.hit27 == true)
        {
            Dam.respawn7 -= 1f * Time.deltaTime;
            foltim7 = 1f;
        }
        if(Dam.respawn7 <= 0 && follow7 == true)
        {
            enemyobj7.SetActive(true);
            RSP7();
            foltim7 -= 1f * Time.deltaTime;
        }
        if(foltim7 <= 0)
        {
            follow7 = false;
            Enemy7.SetDestination(Player.position);
        }

        if(Dam.hit8 == true)
        {
             Dam.hit28 = true;
            
        }
        if(Dam.hit28 == true)
        {
            Dam.respawn8 -= 1f * Time.deltaTime;
            foltim8 = 1f;
        }
        if(Dam.respawn8 <= 0 && follow8 == true)
        {
            enemyobj8.SetActive(true);
            RSP8();
            foltim8 -= 1f * Time.deltaTime;
        }
        if(foltim8 <= 0)
        {
            follow8 = false;
            Enemy8.SetDestination(Player.position);
        }






        Enemy1.SetDestination(Player.position);
        Enemy2.SetDestination(Player.position);
        Enemy3.SetDestination(Player.position);
        Enemy4.SetDestination(Player.position);
        Enemy5.SetDestination(Player.position);
        Enemy6.SetDestination(Player.position);
        Enemy7.SetDestination(Player.position);
        Enemy8.SetDestination(Player.position);


    }

    public void RSP1()
    {
        Enemy1.SetDestination(Player.position);
        Dam.hit1 = false;
        
    }
    public void RSP2()
    {
        Enemy2.SetDestination(Player.position);
        Dam.hit2 = false;
        
    }
    public void RSP3()
    {
        Enemy3.SetDestination(Player.position);
        Dam.hit3 = false;
        
    }
    public void RSP4()
    {
        Enemy4.SetDestination(Player.position);
        Dam.hit4 = false;
        
    }
    public void RSP5()
    {
        Enemy5.SetDestination(Player.position);
        Dam.hit5 = false;
        
    }
    public void RSP6()
    {
        Enemy6.SetDestination(Player.position);
        Dam.hit6 = false;
        
    }
    public void RSP7()
    {
         Enemy7.SetDestination(Player.position);
        Dam.hit7 = false;
        
    }
    public void RSP8()
    {
         Enemy8.SetDestination(Player.position);
        Dam.hit8 = false;
        
    }
    
}
