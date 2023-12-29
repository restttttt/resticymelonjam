using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AxeAttack : MonoBehaviour
{
    public int AxeDamage = 10;
    public BoxCollider boxCol;
    public int FrameCounter = 0;
    public int FrameCounter2 = 0;
    public bool Attacking;
    public bool readyToAttack;
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
        if (FrameCounter > 150 && !Attacking)
        {
            readyToAttack = true;
        }
        if (readyToAttack)
        {
            if (Input.GetMouseButton(0))
            {
                Attacking = true;
                readyToAttack = false;
            }
        }
        if (Attacking)
        {
            boxCol.enabled = true;
            FrameCounter2++;
            if(FrameCounter2 > 150)
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
