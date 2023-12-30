using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public HealthSystem sys;
    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (sys.PlayerHealth == 0)
        {
            cam2.SetActive(true);
            cam1.SetActive(false);

            Cursor.lockState = CursorLockMode.None;
        }
    }
}
