using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PartV
{
	public class PlayerMovimentation : MonoBehaviour
	{
		// Public attributes
		public float maxSpeed = 5;
		public float jumpSpeed = 5;
		public Animator animator;
		public GameObject playerImage;
		public AudioClip jumpClip;

		// Private attributes
		Rigidbody2D rigidBody;
		bool isJumping = false;
		private bool canPlayAudioAgain = true;
		private PlayerHealth health;
		private AudioSource audioSource;

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
			health = GetComponent<PlayerHealth>();
			audioSource = GetComponent<AudioSource>();
		}

		// Update is called once per frame
		void Update()
		{
			if (health.isDead)
			{
				return;
			}
			
			var x = Input.GetAxis("Horizontal");
			// transform.position += x * maxSpeed * transform.right * Time.deltaTime;
			rigidBody.velocity = new Vector2(x * maxSpeed, rigidBody.velocity.y);
			
			playerImage.transform.localScale = new Vector3(Mathf.Sign(x), 1.0f, 1.0f);

			var jump = Input.GetAxis("Jump");
			if (jump > 0.5 && !isJumping)
			{
				isJumping = true;
				rigidBody.velocity = new Vector2(rigidBody.velocity.x, jump * jumpSpeed);
			}

			if (!isJumping && rigidBody.velocity.magnitude > 0)
			{
				animator.SetBool("Running", true);
			}
			else
			{
				animator.SetBool("Running", false);
			}

			if (isJumping && !audioSource.isPlaying && canPlayAudioAgain)
			{
				canPlayAudioAgain = false;
				audioSource.PlayOneShot(jumpClip);
			}
		}

		// OnCollisionEnter2D is called whenever the player hits something
		void OnCollisionEnter2D(Collision2D other)
		{
			Debug.Log("Collision with: " + other.gameObject.name);
			if (other.contacts[0].normal == Vector2.up)
			{
				canPlayAudioAgain = true;
				isJumping = false;
			}
		}
	}
}