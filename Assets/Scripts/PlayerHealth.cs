﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    private int health = 100;

    public Text text;

    void Start()
    {
        text.text = "VIDA: " + health;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
      if(other.gameObject.CompareTag("Water"))
      {
        health -= 10;
        text.text = "VIDA: " + health;
      }
    }
}