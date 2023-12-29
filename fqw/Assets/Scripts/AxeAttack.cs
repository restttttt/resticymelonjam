using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AxeAttack : MonoBehaviour
{
    public int AxeDamage = 10;
    public BoxCollider boxCol;
    public int i = 0;
    public bool Attacking;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if (Input.GetMouseButton(0) && i == 300)
        {
            Attacking = true;
            boxCol.gameObject.SetActive(true);
        }else if (i == 600)
        {
            Attacking = false;
            boxCol.gameObject.SetActive(false);
        }

    }
}
