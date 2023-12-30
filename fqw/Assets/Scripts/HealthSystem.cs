using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class HealthSystem : MonoBehaviour
{
    public int PlayerHealth = 100;
    public GameObject DedScreen;
    public Image Blood;
    private Color color;
    public bool JustChanged;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            PlayerHealth -= 10;
            Debug.Log("PlayerHealth = " + PlayerHealth);
            JustChanged = true;
        }
    }
    void Update()
    {
        color = Blood.color;
        color.a-= PlayerHealth;

        
        Blood.color = color;
        if (PlayerHealth == 0)
        {
            DedScreen.SetActive(true);
        }
        
    }


}
