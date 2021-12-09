using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDialogo : MonoBehaviour
{
    public Tester _tester; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            _tester.StartConvo();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
