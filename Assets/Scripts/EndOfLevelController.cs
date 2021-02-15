using UnityEngine;

/*




NAO SEI OQ FAZ




*/


/*
 * Classe: EndOfLevelController
 * Descrição: Ao colidir com o player, abra-se uma caixa de diálogo
 */
public class EndOfLevelController : MonoBehaviour
	{
		//Atributo do objeto player
		public GameObject player;

		//Posição X inicial do player
		public float playerInitialX = -6.5f;

		//Posição X inicial do player
		public float playerInitialY = 3.75f;

		//Posição X inicial da câmera
		public float cameraInitialX = 0;

		void OnCollisionEnter2D(Collision2D other)
		{

			var playerPosition = player.transform.position;
			player.transform.position = new Vector3(playerInitialX, playerInitialY, playerPosition.z);

			var cameraPosition = Camera.main.transform.position;
			Camera.main.transform.position = new Vector3(cameraInitialX, cameraPosition.y, cameraPosition.z);
		}
	}
