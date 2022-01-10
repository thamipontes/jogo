using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDialogo : MonoBehaviour
{
    public Tester _tester; 
    int indicador;

    void Start()
    {
        indicador = 1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            if (indicador == 1) {
                _tester.StartConvo();
                indicador = 2;
            }
        }
    }
}

