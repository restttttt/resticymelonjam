using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public talismanget tal;
    public timer tim;
    public Text text;
    public Text text1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = tim.time.ToString();
        text.text = tal.score1.ToString();
    }
}
