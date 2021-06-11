using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public bool dialogue = true;
    public GameObject musicaDeFundo;

    void Awake()
    {
        if(PlayerPrefs.GetInt("Musica") == 1){
            musicaDeFundo.SetActive(false);
        } else {
            musicaDeFundo.SetActive(true);
        }
    }

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

    public void BoolButtonMusica()
    {
        if(musicaDeFundo.activeSelf){
            musicaDeFundo.SetActive(false);
            PlayerPrefs.SetInt("Musica", 1);
            Debug.Log("Musica false");
        } else {
            musicaDeFundo.SetActive(true);
            PlayerPrefs.SetInt("Musica", 0);
            Debug.Log("Musica true");
        }
        PlayerPrefs.Save();
    }
}