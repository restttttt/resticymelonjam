using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttHeaMan : MonoBehaviour
{
    public GameObject Heal;
    public GameObject Mana;
    public GameObject Attack;
    public bool HealHold = false;
    public bool ManaHold = false;
    public bool AttackHold = false;
    public float HealAm;
    public float ManaAm;
    public float AttAm;
    public Camera cam;
    public float range = 5f;
    public bool lookatitem = false;

    //damage
    public float enemyhealth = 2f;
    public GameObject AttackBox;
    public float attacktimer;
    public bool anotheratt = false;
    public bool attcked = false;
    // Start is called before the first frame update
    void Start()
    {
        Heal.SetActive(false);
        Mana.SetActive(false);
        Attack.SetActive(false);
        HealAm = 0f;
        ManaAm = 0f;
        AttAm = 0f;

        //damage
        AttackBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        lookatitem = false;

        if(HealHold == true)
        {
            Heal.SetActive(true);   
            Mana.SetActive(false);
            Attack.SetActive(false);
        }
        if(ManaHold == true)
        {
            Mana.SetActive(true);      
            Heal.SetActive(false);
            Attack.SetActive(false);
        }
        if(AttackHold == true)
        {
            Attack.SetActive(true);
            Mana.SetActive(false);
            Heal.SetActive(false);
        }

        RaycastHit Ornaments;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out Ornaments, range))
        {
            Debug.Log(Ornaments.transform.tag);
            if(Ornaments.transform.tag == "Heal")
            {
                lookatitem = true;
                if(Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("+1 Heal");
                    Heal.SetActive(true);
                    HealAm += 1f;
                    Mana.SetActive(false);
                    Attack.SetActive(false);
                    HealHold = true;
                    ManaHold = false;
                    AttackHold = false;
                    Destroy(Ornaments.transform.gameObject);
                }
            }
            if(Ornaments.collider.tag == "Mana")
            {
                lookatitem = true;
                if(Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("+1 Man");
                    Mana.SetActive(true);
                    ManaAm += 1f;
                    Heal.SetActive(false);
                    Attack.SetActive(false);
                    ManaHold = true;
                    HealHold = false;
                    AttackHold = false;
                    Destroy(Ornaments.transform.gameObject);
                }
            }
            if(Ornaments.collider.tag == "Attack")
            {
                lookatitem = true;
                if(Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("+1 att");
                    Attack.SetActive(true);
                    AttAm += 1f;
                    Mana.SetActive(false);
                    Heal.SetActive(false);
                    AttackHold = true;
                    HealHold = false;
                    ManaHold = false;
                    Destroy(Ornaments.transform.gameObject);
                }
                
            }
        }

        

        if(Input.GetKeyDown(KeyCode.Alpha1) && HealAm >= 1)
        {
            HealHold = true;
            ManaHold = false;
            AttackHold = false;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2) && ManaAm >= 1)
        {
            ManaHold = true;
            HealHold = false;
            AttackHold = false;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3) && AttAm >= 1)
        {
            AttackHold = true;
            HealHold = false;
            ManaHold = false;
        }

        //damage
        if(HealAm != 0 && lookatitem == false)
        {
            if(Input.GetKeyDown(KeyCode.E) && HealHold)
            {
                HealAm -= 1f;
            }
        }
        if(ManaAm != 0 && lookatitem == false)
        {
            if(Input.GetKeyDown(KeyCode.E) && ManaHold)
            {
                ManaAm -= 1f;
            }
        }
        if(AttAm != 0 && lookatitem == false)
        {
            if(Input.GetKeyDown(KeyCode.E) && AttackHold)
            {
                attacktimer = 2f;
                AttAm -= 1f;
                AttackBox.SetActive(true);
                attcked = true;
            }
        }

        if(attcked == true)
        {
            attacktimer -= 1f * Time.deltaTime;
        }

        if(attacktimer <= 0)
        {
            AttackBox.SetActive(false);
            attcked = false;
        }

        

        if(HealAm <= 0)
        {
            HealHold = false;
            Heal.SetActive(false);
        }
        if(ManaAm <= 0)
        {
            ManaHold = false;
            Mana.SetActive(false);
        }
        if(AttAm <= 0)
        {
            AttackHold = false;
            Attack.SetActive(false);
        }

        


        
    }
}
