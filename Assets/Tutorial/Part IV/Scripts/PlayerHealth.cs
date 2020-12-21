using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PartIV
{
    public class PlayerHealth : MonoBehaviour
    {
        public bool isDead;
        public Text resultText;
        public Button button;
        public int health = 100;
        public Text text;

        private void Start()
        {
            text.text = "HP: " + health;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                health -= 50;
                text.text = "HP: " + health;

                if (health <= 0)
                {
                    isDead = true;
                    resultText.gameObject.SetActive(true);
                    button.gameObject.SetActive(true);
                    resultText.text = "Derrota";
                } 
            }
        }
    }
}
