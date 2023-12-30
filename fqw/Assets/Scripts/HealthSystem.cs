using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthSystem : MonoBehaviour
{
    public int PlayerHealth = 100;
    
    public Slider slider;

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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        slider.value = PlayerHealth;
        
    }


}
