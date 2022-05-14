using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Bateria : MonoBehaviour
{
    private Light2D light2D;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            light2D = other.gameObject.GetComponentInChildren<Light2D>();
            light2D.intensity = 1;
            gameObject.SetActive(false);
        }
    }
}
