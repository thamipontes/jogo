using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroySound : MonoBehaviour
{
    void Awake()
    {
        GameObject[] som = GameObject.FindGameObjectsWithTag("Sons");

        if (som.Length > 1) {
            Destroy(this.gameObject);
        }
        
        DontDestroyOnLoad(this.gameObject);
    }

}
