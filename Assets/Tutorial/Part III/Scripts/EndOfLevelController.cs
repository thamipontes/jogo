using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PartIII
{
	public class EndOfLevelController : MonoBehaviour
	{
		// Public attributes
		public GameObject player;
		public float playerInitialX = -6.5f;
		public float playerInitialY = 3.75f;
		public float cameraInitialX = 0;

		// Start is called before the first frame update
		void Start()
		{
		}

		// Update is called once per frame
		void Update()
		{

		}

		// OnCollisionEnter2D is called whenever the player hits the end of the level
		void OnCollisionEnter2D(Collision2D other)
		{
			Debug.Log("You Win!!");

			var playerPosition = player.transform.position;
			player.transform.position = new Vector3(playerInitialX, playerInitialY, playerPosition.z);

			var cameraPosition = Camera.main.transform.position;
			Camera.main.transform.position = new Vector3(cameraInitialX, cameraPosition.y, cameraPosition.z);
		}
	}
}
