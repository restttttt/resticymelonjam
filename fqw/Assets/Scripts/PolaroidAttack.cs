using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class PolaroidAttack : MonoBehaviour
{
    public int PolaroidDmg;
    public AttHeaMan CharmMan;
    public int FrameCounter = 0;
    public int FrameCounter2 = 0;
    public bool Attacking;
    public bool readyToAttack;
    public BoxCollider boxCol;
    public GameObject Flash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FrameCounter++;
        if(FrameCounter > 250 && !Attacking)
        {
            readyToAttack = true;
        }

        if(readyToAttack && CharmMan.mana >= 5)
        {
            if (Input.GetMouseButtonDown(0))
            {
                CharmMan.mana -= 5;
                Attacking = true;
                readyToAttack = false;
            }
        }
        if (Attacking)
        {
            boxCol.enabled = true;
            Flash.SetActive(true);
            FrameCounter2++;
            if(FrameCounter2 >= 30)
            {
                FrameCounter = 0;
                FrameCounter2 = 0;
                readyToAttack = true;
                Attacking = false;
                boxCol.enabled = false;
                Flash.SetActive(false);
            }
        }

    }
}
