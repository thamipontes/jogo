using System;
using UnityEngine;

namespace PartII {
	public class PlayerMovimentation : MonoBehaviour
	{
		// Public attributes
		public float maxSpeed = 5;
		public float jumpSpeed = 5;

		public Boolean isJumping = false;

		// Private attributes
		Rigidbody2D rigidBody2D;

		// Start is called before the first frame update
		// Here you can handle with all objects in the scene
		void Start()
		{
		}

		// Awake is called before the first frame update
		// Here you can handle with all components in the object
		void Awake()
		{
			rigidBody2D = GetComponent<Rigidbody2D>();
		}

		// Update is called once per frame
		void Update()
		{
			var x = Input.GetAxis("Horizontal");
			// transform.position += x * maxSpeed * transform.right * Time.deltaTime;
			rigidBody2D.velocity = new Vector2(x * maxSpeed, rigidBody2D.velocity.y);

			
			if (Input.GetAxis("Jump") == 1.0f && !isJumping){
				//[0,1] adicionando 1 no y indo pra cima
				isJumping = true;
				rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, jumpSpeed);
			}
		}

		
		private void OnCollisionEnter2D(Collision2D other) {
			//Quando cair no chão, ele muda isJumping pra false, ou seja, não está 
			isJumping = false;
			
		}

	}
}


