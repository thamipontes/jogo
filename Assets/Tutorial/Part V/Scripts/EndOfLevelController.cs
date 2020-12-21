using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PartV
{
	public class EndOfLevelController : MonoBehaviour
	{
		// Public attributes
		public Text resultText;
		public Button button;


		// OnCollisionEnter2D is called whenever the player hits the end of the level
		void OnCollisionEnter2D(Collision2D other)
		{
			Debug.Log("You Win!!");
			resultText.gameObject.SetActive(true);
			button.gameObject.SetActive(true);
			resultText.text = "Vitória";
		}
	}
}
