using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PartIV
{
	public class CameraController : MonoBehaviour
	{
		// Public attributes
		public GameObject player;
		public float minX = 0;
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
				transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
			}
		}
	}
}
