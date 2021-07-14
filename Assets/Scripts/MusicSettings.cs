using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSettings : MonoBehaviour
{

    public GameObject musicaDeFundo;
    public Image botaoMusica;
    public Sprite musicOn, musicOff;

    private void Start(){
      if(PlayerPrefs.GetInt("Musica") == 1){
        botaoMusica.sprite = musicOff;
      } else {
        botaoMusica.sprite = musicOn;
      }
    }

    public void BoolButtonMusica()
    {
        if(!musicaDeFundo.activeSelf){
            musicaDeFundo.SetActive(true);
            PlayerPrefs.SetInt("Musica", 0);
            Debug.Log("Musica true");
            botaoMusica.sprite = musicOn;
        } else {
            musicaDeFundo.SetActive(false);
            PlayerPrefs.SetInt("Musica", 1);
            Debug.Log("Musica false");
            botaoMusica.sprite = musicOff;
        }
        PlayerPrefs.Save();
    }
}
