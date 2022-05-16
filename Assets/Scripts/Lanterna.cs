using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Lanterna : MonoBehaviour
{
    private Light2D light2D;
    public int velocidadeCarga;
    void Awake()
    {
        light2D = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (light2D.enabled)
        {
            light2D.intensity -= (Time.deltaTime)/velocidadeCarga;
        }
    }
}
