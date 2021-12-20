using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
public class ControleConquistas : MonoBehaviour {
    public Image conquista1;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Conquista 1") == 1)
        {
            conquista1.gameObject.SetActive(true);
        }


    }

}
