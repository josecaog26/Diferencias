using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Image img;
    
    void Start(){

    }
    public void ButtonClicked(){
        if (Input.GetKeyDown(KeyCode.A)){
            img.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.D)){
            img.enabled = true;
        }
        
    }

}
