using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static bool dialogue;


    void Start()
    {
        dialogue = true;
    }


    public void DialogueManager()
    {
        if(dialogue){
            dialogue = false;
            Debug.Log("dialogo falso");
        } else {
            dialogue = true;
            Debug.Log("dialogo true");
        }
    }


}
