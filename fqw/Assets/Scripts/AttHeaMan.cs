using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttHeaMan : MonoBehaviour
{
    public HealthSystem healthsys;
    public AxeAttack Axeattk;
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
    public float mana = 0f;
    public float attack = 0f;
    public AudioSource pickUp;
    public bool Axedam = false;
    public Slider ManaSlider;

    public AudioSource useCharm;

    
    // Start is called be.efore the first frame update
    void Start()
    {
        Heal.SetActive(false);
        Mana.SetActive(false);
        Attack.SetActive(false);
        HealAm = 0f;
        ManaAm = 0f;
        AttAm = 0f;

        
    }

    // Update is called once per frame
    void Update()
    {
        ManaSlider.value = mana;
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
            //Debug.Log(Ornaments.transform.tag);
            if(Ornaments.transform.tag == "Heal")
            {
                lookatitem = true;

                if(Input.GetKeyDown(KeyCode.E))
                {
                    pickUp.Play();
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
                    pickUp.Play();
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
                if(Input.GetKeyDown(KeyCode.E) && attack <= 5)
                {
                    pickUp.Play();
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

        
        if(HealAm != 0 && lookatitem == false)
        {
            if(Input.GetKeyDown(KeyCode.E) && HealHold)
            {
                HealAm -= 1f;
                healthsys.PlayerHealth += 10;
                useCharm.Play();
            }
        }
        if(ManaAm != 0 && lookatitem == false)
        {
            if(Input.GetKeyDown(KeyCode.E) && ManaHold)
            {
                if(mana <= 40)
                {
                    ManaAm -= 1f;
                    mana += 10f;
                    useCharm.Play();
                }
            }
        }
        if(AttAm != 0 && lookatitem == false)
        {
            if(Input.GetKeyDown(KeyCode.E) && AttackHold)
            {
                attack += 1f;
                AttAm -= 1f;
                useCharm.Play();
            }
        }
        if(mana != 0 && attack != 0)
        {
            Axeattk.AxeDamage = 10;
            Axedam = true;
        }
        else
        {
            Axeattk.AxeDamage = 5;
            Axedam = false;
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
