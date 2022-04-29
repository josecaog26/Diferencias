using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fails : MonoBehaviour
{
    public int clicks;
    public Text FailText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FailText.text = clicks.ToString();
    }

    public void CountClicks(){
        clicks++;
    }
}

