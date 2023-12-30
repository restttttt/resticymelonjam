using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthSystem : MonoBehaviour
{
    public int PlayerHealth = 100;
    
    public Slider slider;

    public GameObject cam1;
    public GameObject cam2;

    void Start()
    {
        
    }
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
        
        slider.value = PlayerHealth;
        
    }


}
