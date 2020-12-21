using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PartIII
{
	public class PlayerMovimentation : MonoBehaviour
	{
		// Public attributes
		public float maxSpeed = 5;
		public float jumpSpeed = 5;

		// Private attributes
		Rigidbody2D rigidBody;
		bool isJumping = false;

		// Start is called before the first frame update
		// Here you can handle with all objects in the scene
		void Start()
		{
		}

		// Awake is called before the first frame update
		// Here you can handle with all components in the object
		void Awake()
		{
			rigidBody = GetComponent<Rigidbody2D>();
		}

		// Update is called once per frame
		void Update()
		{
			var x = Input.GetAxis("Horizontal");
			// transform.position += x * maxSpeed * transform.right * Time.deltaTime;
			rigidBody.velocity = new Vector2(x * maxSpeed, rigidBody.velocity.y);

			
			

			var jump = Input.GetButtonDown("Jump");
			if (jump && !isJumping)
			{
				isJumping = true;				
				rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
			}
		}

		// OnCollisionEnter2D is called whenever the player hits something
		void OnCollisionEnter2D(Collision2D other)
		{
			Debug.Log("Collision with: " + other.gameObject.name);
			
			//Se a normal do meu chão for para cima ai sim bateu no chão, se não for apenas não faz nada
			if (other.contacts[0].normal == Vector2.up)
			{
				isJumping = false;
				
			}
		}
	}
}