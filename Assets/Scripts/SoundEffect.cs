using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffect : MonoBehaviour
{
    public Image botaoSound;
    public Sprite soundOn, soundOff;

    void Start()
    {
      if(PlayerPrefs.GetInt("EfeitoSonoro") == 1){
        botaoSound.sprite = soundOff;
      } else {
        botaoSound.sprite = soundOn;
      }
    }

    public void BoolButtonEfeitoSonoro()
    {
        int prefs = PlayerPrefs.GetInt("EfeitoSonoro");
        if(prefs == 0){
            // sound.SetActive(false);
            PlayerPrefs.SetInt("EfeitoSonoro", 1);
            botaoSound.sprite = soundOff;
        } else {
            // sound.SetActive(true);
            PlayerPrefs.SetInt("EfeitoSonoro", 0);
            botaoSound.sprite = soundOn;
        }
        Debug.Log("EfeitoSonoro: " + PlayerPrefs.GetInt("EfeitoSonoro"));
        PlayerPrefs.Save();
    }
}
