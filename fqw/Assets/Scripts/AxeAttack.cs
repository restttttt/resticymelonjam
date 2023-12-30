using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AxeAttack : MonoBehaviour
{
    public Animator anim;
    public EnemyAI enemyai;
    public AttHeaMan charmmanager;
    public int AxeDamage = 10;
    public BoxCollider boxCol;
    public int FrameCounter = 0;
    public int FrameCounter2 = 0;
    public bool Attacking;
    public bool readyToAttack;
    
    public GameObject  bloodVFX;
    public GameObject bloodpos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private BoxCollider GetBoxCol()
    {
        return boxCol;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FrameCounter++;
        if (FrameCounter > 30 && !Attacking)
        {
            readyToAttack = true;
        }
        if (readyToAttack && charmmanager.mana != 0)
        {
            if (Input.GetMouseButton(0))
            {
                charmmanager.mana -= 1f;
                Attacking = true;
                readyToAttack = false;
                anim.SetTrigger("swing");

                

                
                

                if(charmmanager.Axedam)
                {
                    charmmanager.attack -= 1f;
                }

            }
        }
        if (Attacking)
        {
            boxCol.enabled = true;
            FrameCounter2++;
            if(FrameCounter2 > 30)
            {
                FrameCounter = 0;
                FrameCounter2 = 0;
                readyToAttack = true;
                Attacking = false;
                boxCol.enabled = false;
            }           
        }

    }
}
