using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Image img;
    
    void Start(){

        img.enabled = false;

    }
    public void ButtonClicked(){
        
        img.enabled = true;
        
    }

}
