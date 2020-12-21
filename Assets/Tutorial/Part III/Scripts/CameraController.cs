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
		public float minX = 0;
		//Para definir o min e max é só olhar a posição da camera no unity (posicao X), onde vc quer começar e onde
		public float maxX = 35;

		// Start is called before the first frame update
		void Start()
		{
		}

		// Update is called once per frame
		void Update()
		{
			if (player.transform.position.x > minX && player.transform.position.x < maxX)
			{
				//transform.position é da camera, pois é o script da camera
				transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
			}
		}
	}
}
