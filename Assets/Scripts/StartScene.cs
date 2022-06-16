using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{
  public GameObject musicaDeFundo;
  public HUDControl _hudControl;

  void Awake()
  {
    Coins.GetMoedas();
    _hudControl.gasolinaBarTransform.localScale = HUDControl.GetGasolina();
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
