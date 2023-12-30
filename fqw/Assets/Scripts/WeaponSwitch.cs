using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public GameObject AxeObj;
    public GameObject CamObj;
    public bool HoldingAxe = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            switch (HoldingAxe)
            {
                case true:
                    AxeObj.SetActive(false);
                    CamObj.SetActive(true);
                    HoldingAxe = false;
                    break;
                case false:
                    AxeObj.SetActive(true);
                    CamObj.SetActive(false);
                    HoldingAxe = true;
                    break;
            }
        }
    }
}
