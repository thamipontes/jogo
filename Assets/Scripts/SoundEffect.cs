using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public GameObject sound;

    void Awake()
    {
        if(PlayerPrefs.GetInt("EfeitoSonoro") == 0){
            sound.SetActive(false);
        } else {
            sound.SetActive(true);
        }
    }

    public void BoolButtonEfeitoSonoro()
    {
        int prefs = PlayerPrefs.GetInt("EfeitoSonoro");
        if(prefs == 1){
            sound.SetActive(false);
            PlayerPrefs.SetInt("EfeitoSonoro", 0);
            Debug.Log("EfeitoSonoro false");
        } else {
            sound.SetActive(true);
            PlayerPrefs.SetInt("EfeitoSonoro", 1);
            Debug.Log("EfeitoSonoro true");
        }
        PlayerPrefs.Save();
    }
}
