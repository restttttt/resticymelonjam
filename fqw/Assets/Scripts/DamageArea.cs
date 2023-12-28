using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageArea : MonoBehaviour
{
    public EnemyFollow EF;
    public bool hit1 = false;
    public bool hit2 = false;
    public bool hit3 = false;
    public bool hit4 = false;
    public bool hit5 = false;
    public bool hit6 = false;
    public bool hit7 = false;
    public bool hit8 = false;
    public bool hit21 = false;
    public bool hit22 = false;
    public bool hit23 = false;
    public bool hit24 = false;
    public bool hit25 = false;
    public bool hit26 = false;
    public bool hit27 = false;
    public bool hit28 = false;
    public float respawn1 = 10f;
    public float respawn2 = 10f;
    public float respawn3 = 10f;
    public float respawn4 = 10f;
    public float respawn5 = 10f;
    public float respawn6 = 10f;
    public float respawn7 = 10f;
    public float respawn8 = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hit1 == true)
        {
            hit21 = true;
            
        }
        if(hit21 == true)
        {
            respawn1 -= 1f * Time.deltaTime;
        }
        if(respawn1 <= 0)
        {
            EF.enemyobj1.SetActive(true);
            EF.RSP1();
        }

        if(hit2 == true)
        {
            hit22 = true;
            
        }
        if(hit22 == true)
        {
            respawn2 -= 1f * Time.deltaTime;
        }
        if(respawn2 <= 0)
        {
             EF.enemyobj2.SetActive(true);
            EF.RSP2();
        }

        if(hit3 == true)
        {
            hit23 = true;
            
        }
        if(hit23 == true)
        {
            respawn3 -= 1f * Time.deltaTime;
        }
        if(respawn3 <= 0)
        {
             EF.enemyobj3.SetActive(true);
            EF.RSP3();
        }

        if(hit4 == true)
        {
            hit24 = true;
            
        }
         if(hit24 == true)
         {
            respawn4 -= 1f * Time.deltaTime;
         }
        if(respawn4 <= 0)
        {
             EF.enemyobj4.SetActive(true);
            EF.RSP4();
        }

        if(hit5 == true)
        {
            hit25 = true;
            
        }
        if(hit25 == true)
        {
            respawn5 -= 1f * Time.deltaTime;
        }
        if(respawn5 <= 0)
        {
             EF.enemyobj5.SetActive(true);
            EF.RSP5();
        }

        if(hit6 == true)
        {
            hit26 = true;
            
        }
        if(hit26 == true)
        {
            respawn6 -= 1f * Time.deltaTime;
        }
        if(respawn6 <= 0)
        {
             EF.enemyobj6.SetActive(true);
            EF.RSP6();
        }

        if(hit7 == true)
        {
             hit27 = true;
            
        }
        if(hit27 == true)
        {
            respawn7 -= 1f * Time.deltaTime;
        }
        if(respawn7 <= 0)
        {
             EF.enemyobj7.SetActive(true);
            EF.RSP7();
        }

        if(hit8 == true)
        {
             hit28 = true;
            
        }
        if(hit28 == true)
        {
            respawn8 -= 1f * Time.deltaTime;
        }
        if(respawn8 <= 0)
        {
             EF.enemyobj8.SetActive(true);
            EF.RSP8();
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy1")
        {
            other.gameObject.SetActive(false);
            hit1 = true;
            EF.follow1 = true;
        }
       

        if(other.gameObject.tag == "Enemy2")
        {
            other.gameObject.SetActive(false);
            hit2 = true;
            EF.follow2 = true;
        }
        

        if(other.gameObject.tag == "Enemy3")
        {
            other.gameObject.SetActive(false);
            hit3 = true;
            EF.follow3 = true;
        }
        

        if(other.gameObject.tag == "Enemy4")
        {
            other.gameObject.SetActive(false);
            hit4 = true;
            EF.follow4 = true;
        }
        

        if(other.gameObject.tag == "Enemy5")
        {
            other.gameObject.SetActive(false);
            hit5 = true;
            EF.follow5 = true;
        }
        

        if(other.gameObject.tag == "Enemy6")
        {
            other.gameObject.SetActive(false);
            hit6 = true;
            EF.follow6 = true;
        }
        

        if(other.gameObject.tag == "Enemy7")
        {
            other.gameObject.SetActive(false);
            hit7 = true;
            EF.follow7 = true;
        }
        

        if(other.gameObject.tag == "Enemy8")
        {
            other.gameObject.SetActive(false);
            hit8 = true;
            EF.follow8 = true;
        }
        
    }
}
