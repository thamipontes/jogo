using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bateria : MonoBehaviour
{
    private UnityEngine.Rendering.Universal.Light2D light2D;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            light2D = other.gameObject.GetComponentInChildren<UnityEngine.Rendering.Universal.Light2D>();
            light2D.intensity = 1;
            gameObject.SetActive(false);
        }
    }
}
