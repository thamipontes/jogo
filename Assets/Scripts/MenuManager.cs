using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public bool dialogue = true;
    public Image botaoDialogo;
    public Sprite dialogoOn, dialogoOff;

    void Start(){
      if(PlayerPrefs.GetInt("dialogue") == 1){
        botaoDialogo.sprite = dialogoOff;
        dialogue = false;
      } else {
        botaoDialogo.sprite = dialogoOn;
        dialogue = true;
      }
    }

    public void BoolButtonDialogue()
    {
        if(dialogue){
            PlayerPrefs.SetInt("dialogue", 1);
            dialogue = false;
            botaoDialogo.sprite = dialogoOff;
            PlayerPrefs.Save();
            Debug.Log("dialogo falso");
        } else {
            PlayerPrefs.SetInt("dialogue", 0);
            dialogue = true;
            botaoDialogo.sprite = dialogoOn;
            PlayerPrefs.Save();
            Debug.Log("dialogo true");
        }
    }

}
