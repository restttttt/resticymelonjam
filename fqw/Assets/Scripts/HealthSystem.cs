using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class HealthSystem : MonoBehaviour
{
    public int PlayerHealth = 100;
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            PlayerHealth -= 10;
            Debug.Log("PlayerHealth = " + PlayerHealth);
        }
    }

}
