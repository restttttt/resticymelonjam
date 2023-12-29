using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class HealthSystem : MonoBehaviour
{
    public int PlayerHealth = 100;
    public GameObject DedScreen;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            PlayerHealth -= 10;
            Debug.Log("PlayerHealth = " + PlayerHealth);
        }
    }
    void Update()
    {
        if (PlayerHealth == 0)
        {
            DedScreen.SetActive(true);
        }
    }


}
