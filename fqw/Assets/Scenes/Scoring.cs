using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public talismanget tal;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = tal.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
