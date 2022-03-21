using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerCena : MonoBehaviour {

    public string Cena = "cena";
    public float tempo = 8;

    float cronometro = 0;

   void Update () {
        cronometro += Time.deltaTime;
        if(cronometro > tempo ){
            SceneManager.LoadScene(Cena);
        }
   }
}