using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VitoriaDerrota : MonoBehaviour
{
		 // Public attributes
   		public Text resultText;
   		public Button button;

        // OnCollisionEnter2D is called whenever the player hits the end of the level
        private void OnTriggerEnter2D(Collider2D other)
        {
	        if (other.gameObject.CompareTag("MoedaFinal"))
	        {
		        
		        resultText.text = "Vitória";
		        resultText.gameObject.SetActive(true);
		        button.gameObject.SetActive(true);
	        }

	        if (other.gameObject.CompareTag("Buraco"))
	        {
		        resultText.text = "Derrota";
		        resultText.gameObject.SetActive(true);
		        button.gameObject.SetActive(true);
	        }
        }

}
