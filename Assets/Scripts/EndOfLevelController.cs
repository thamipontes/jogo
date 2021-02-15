using UnityEngine;

public class EndOfLevelController : MonoBehaviour
	{
		// Public attributes
		public GameObject player;
		public float playerInitialX = -6.5f;
		public float playerInitialY = 3.75f;
		public float cameraInitialX = 0;

		void OnCollisionEnter2D(Collision2D other)
		{
			
			var playerPosition = player.transform.position;
			player.transform.position = new Vector3(playerInitialX, playerInitialY, playerPosition.z);

			var cameraPosition = Camera.main.transform.position;
			Camera.main.transform.position = new Vector3(cameraInitialX, cameraPosition.y, cameraPosition.z);
		}
	}

