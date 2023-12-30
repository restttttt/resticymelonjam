using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talismanget : MonoBehaviour
{
    public float score = 0f;
    public float score1;
    public Camera cam;
    public float range = 5f;
    public AudioSource get;
    public AttHeaMan at;
    public float charm = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        




        

        
        
        score1 = score;
        RaycastHit hit;
if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
{
    if (hit.transform.CompareTag("Talisman"))
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(hit.transform.gameObject);
            get.Play();
            score += 1f;
            charm += 1f;
         
        }
    }
}
    }
}
