using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class HealthSystem : MonoBehaviour
{
    public int PlayerHealth = 100;
    public GameObject DedScreen;
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
            DedScreen.SetActive(true);
        }
        slider.value = PlayerHealth;
        
    }


}
