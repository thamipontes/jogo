using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public bool dialogue = true;

    public void BoolButtonDialogue()
    {
        if(dialogue){
            PlayerPrefs.SetInt("dialogue", 1);
            dialogue = false;
            PlayerPrefs.Save();
            Debug.Log("dialogo falso");
        } else {
            PlayerPrefs.SetInt("dialogue", 0);
            dialogue = true;
            PlayerPrefs.Save();
            Debug.Log("dialogo true");
        }
    }
    
}