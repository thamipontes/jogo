using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PartIII
{
	public class CameraController : MonoBehaviour
	{
		// Public attributes
		public GameObject player;
		//Tem que ir no unity e pegar o objeto que é seu player e arrastar pro script onde tem esse nome de variável (player)
		// public float minX = 0;
		//Para definir o min e max é só olhar a posição da camera no unity (posicao X), onde vc quer começar e onde
		// public float maxX = 35;

		private Vector2 velocity;

   	public float smoothTimeY;
   	public float smoothTimeX;
   	public float deltaY;
		// public float minY;
		// public float maxY;
		// public float minX;
		// public float maxX;

		// Start is called before the first frame update
		void Start()
		{
		}

		// Update is called once per frame
		//void Update()
		void  FixedUpdate()
		{
			// if (player.transform.position.x > minX && player.transform.position.x < maxX)
			// {
			// 	//transform.position é da camera, pois é o script da camera
			// 	transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
			// }



				float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
				float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y + deltaY, ref velocity.y, smoothTimeY);

				if (posX <28 && posX>-10 && posY>0.3) {
					transform.position = new Vector3(posX, posY, transform.position.z);
				}

				else {
					if (posY < 0.3){
						posY = 0.3f;
					}
					if (posX < -10){
						posX = -10;
					}
					if (posX > 29){
						posX = 29f;
					}
					transform.position = new Vector3(posX, posY, transform.position.z);
				}
				// if (posY < 0.3) {
				// 	if (posX > 28) {
				// 		transform.position = new Vector3(28f, 0.3f, transform.position.z);
				// 	}
				// 	else if (posX < -5.24) {
				// 		transform.position = new Vector3(-5.24f, 0.3f, transform.position.z);
				// 	}
				// 	else {
				// 		transform.position = new Vector3(posX, 0.3f, transform.position.z);
				// 	}
				// }
				// else {
				//
				// }


			// Mathf.SmoothDamp(current.position, target.position, current.velocity, reaction.time)
			// // codigo que funciona bontinho
			// float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
			// float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y + deltaY, ref velocity.y, smoothTimeY);
			// transform.position = new Vector3(posX, posY, transform.position.z);



		}
	}
}
