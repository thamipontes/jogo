using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{
  public GameObject musicaDeFundo;

  void Awake()
  {
    AwakeMusic();
  }

  private void AwakeMusic(){
    Debug.Log("Awake Music, saved: " + PlayerPrefs.GetInt("Musica"));
    if(PlayerPrefs.GetInt("Musica") == 1){
      musicaDeFundo.SetActive(false);
    } else {
      musicaDeFundo.SetActive(true);
    }
  }
}
