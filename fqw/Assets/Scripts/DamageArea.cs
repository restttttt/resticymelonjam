using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageArea : MonoBehaviour
{

    // Bool to indicate if the object has been hit
    public bool defeated = false;
    

    // This method is called when a collider enters the trigger collider of this GameObject
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered!");
        
        if (other.CompareTag("Enemy"))
        {
            if (other.gameObject != null)
            {
                // Destroy the enemy clone
                Destroy(other.gameObject);

            
                defeated = true;

            }
            

            
        }
    }
}
