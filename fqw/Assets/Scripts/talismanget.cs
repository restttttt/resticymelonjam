using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talismanget : MonoBehaviour
{
    public float score = 0f;
    public Camera cam;
    public float range = 5f;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
{
    if (hit.transform.CompareTag("Talisman"))
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(hit.transform.gameObject);
            score += 1f;
        }
    }
}
    }
}
