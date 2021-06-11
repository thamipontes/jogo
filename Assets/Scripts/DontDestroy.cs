using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private GameObject[] music;
   
    void Start(){
        music = GameObject.FindGameObjectsWithTag ("Music");
        Destroy (music[1]);
    }
    
    // Update is called once per frame
    void Awake () {
        DontDestroyOnLoad (transform.gameObject);
    }
}
