using System;
using UnityEngine;

namespace PartII {
	public class ElaineMovimentation : MonoBehaviour
	{
		public float speed = 1.0f;
		public float jump = 1.0f;
		// Public attributes
		void Update (){
			float horizontal = Input.GetAxis("Horizontal");
			transform.Translate(new Vector3(horizontal*speed*Time.deltaTime, 0, 0));
			//float jump = Imput.GetAxis("Jump");
		//	transform.Translate(new Vector2(rigidBody2D.velocity.x, 0);
			//animator.SetBool("taPulando", true);
			


		}

	
	}
}
