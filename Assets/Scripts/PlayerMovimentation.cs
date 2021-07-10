using System;
using UnityEngine;
using System.Collections;

namespace PartII {
	public class PlayerMovimentation : MonoBehaviour
	{
		// Public attributes
		public static AudioClip pulo, passos;
		public AudioSource audiosource;

		public float maxSpeed = 5;
		public float jumpSpeed = 5;
		public Tester tester;

		public Boolean isJumping = false;
		public Animator animator;
		private int direction = 1;
		private float originalXScale;

		public bool moveRight, moveLeft;


		// Private attributes

		Rigidbody2D rigidBody2D;


		void Start()
		{
			passos = Resources.Load<AudioClip>("PASSOS_01");
			pulo = Resources.Load<AudioClip>("PULO_01");
			originalXScale = transform.localScale.x;
		}

		// Awake is called before the first frame update
		// Here you can handle with all components in the object
		void Awake()
		{
			rigidBody2D = GetComponent<Rigidbody2D>();
			//Localiza a animação do personagem quando começa o jogo
			animator = GetComponent<Animator>();
		}

		// Update is called once per frame
		private void FixedUpdate()
		{
			if (moveRight)
			{
				rigidBody2D.velocity = new Vector2(maxSpeed, rigidBody2D.velocity.y);
				direction = 1;
				Vector3 scale = transform.localScale;
				scale.x = originalXScale*direction;
				transform.localScale = scale;
				animator.SetBool("taAndando", true);
				PlaySteps();
			}
			else if (moveLeft)
			{
				rigidBody2D.velocity = new Vector2(-maxSpeed, rigidBody2D.velocity.y);
				direction = -1;
				Vector3 scale = transform.localScale;
				scale.x = originalXScale*direction;
				transform.localScale = scale;
				animator.SetBool("taAndando", true);
				PlaySteps();
			}
			else
			{

				animator.SetBool("taAndando", false);
				var x = Input.GetAxis("Horizontal");
				// transform.position += x * maxSpeed * transform.right * Time.deltaTime;
				rigidBody2D.velocity = new Vector2(x * maxSpeed, rigidBody2D.velocity.y);


				//condição para animação
				if (Input.GetAxis("Horizontal") != 0)
				{
					animator.SetBool("taAndando", true);
					PlaySteps();
				}
				else
				{
					animator.SetBool("taAndando", false);
				}

				if (x * maxSpeed * direction < 0)
				{
					Flip();
				}
			}

			if (Input.GetAxis("Jump") == 1.0f && !isJumping){
				//[0,1] adicionando 1 no y indo pra cima
				isJumping = true;
				if(PlayerPrefs.GetInt("EfeitoSonoro")==1) audiosource.PlayOneShot(pulo);
				rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, jumpSpeed);
				animator.SetBool("taPulando", true);
			}


		}


		public void MoveRightTrue()
		{
			moveRight = true;
		}

		public void MoveRightFalse()
		{
			moveRight = false;
		}

		public void MoveLeftTrue()
		{
			moveLeft = true;

		}

		public void MoveLeftFalse()
		{
			moveLeft = false;
		}



		private void OnCollisionEnter2D(Collision2D other) {
			//Quando cair no chão, ele muda isJumping pra false, ou seja, não está
			isJumping = false;
			animator.SetBool("taPulando", false);

			if (other.gameObject.CompareTag("Dialogo")) {
				tester.StartConvo();
			}

		}

		private void Flip()
		{
			direction *= -1;
			Vector3 scale = transform.localScale;
			scale.x = originalXScale*direction;
			transform.localScale = scale;
		}

		public void Jump()
		{
			if(!isJumping)
			{
				isJumping = true;
				if(PlayerPrefs.GetInt("EfeitoSonoro")==1) audiosource.PlayOneShot(pulo);
				rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, jumpSpeed);
				animator.SetBool("taPulando", true);
			}
		}


		// Toca o som "steps1" com um certo período de pausa entre um som e outro
		void PlaySteps()
		{
			// se audio não estiver tocando então toca audio
			int prefs = PlayerPrefs.GetInt("EfeitoSonoro");
			if(!audiosource.isPlaying && prefs == 1)
			{
				audiosource.PlayOneShot(passos);
			}
		}

	}
}
