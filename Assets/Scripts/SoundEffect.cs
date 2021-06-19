using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public GameObject sound;

    void Awake()
    {
        if(PlayerPrefs.GetInt("EfeitoSonoro") == 1){
            sound.SetActive(false);
        } else {
            sound.SetActive(true);
        }
    }
    
    public void BoolButtonEfeitoSonoro()
    {
        if(sound.activeSelf){
            sound.SetActive(false);
            PlayerPrefs.SetInt("EfeitoSonoro", 1);
            Debug.Log("EfeitoSonoro false");
        } else {
            sound.SetActive(true);
            PlayerPrefs.SetInt("EfeitoSonoro", 0);
            Debug.Log("EfeitoSonoro true");
        }
        PlayerPrefs.Save();
    }
}

