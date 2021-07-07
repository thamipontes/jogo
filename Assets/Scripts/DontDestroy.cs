using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy instance;

    void Awake() {

      if(PlayerPrefs.GetInt("instance") == 0 || instance == null) {
        instance = this;
        PlayerPrefs.SetInt("instance", 1);
        DontDestroyOnLoad(gameObject);
      }
      else {
        PlayerPrefs.SetInt("instance", 0);
        Destroy(gameObject);
      }
      PlayerPrefs.Save();
    }
}
