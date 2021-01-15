using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

	public class playMoviment : MonoBehaviour
	{
		// Public attributes
		public float maxSpeed = 5;
		public float jumpSpeed = 5;

		public Boolean isJumping = false;

		public int maximoPulos = 0;
		public int vida = 100;

		public Text vidaTexto;

		// Declarando a animação
		public Animator animator;


		// Declarando a componente rigidBody do personagem ("ele ter leis físicas")
		Rigidbody2D rigidBody2D;

		void Start()
		{
			vidaTexto.text = "Vidas: " + vida;


		}

		// Awake is called before the first frame update
		// Here you can handle with all components in the object
		void Awake()
		{
			//Atribuindo a variável ridigBody2D a componente rigidBody2D que está no Unity
			rigidBody2D = GetComponent<Rigidbody2D>();
			//Localiza a animação do personagem quando começa o jogo
			animator = GetComponent<Animator>();
		}

		// Update is called once per frame
		void Update()
		{
			var x = Input.GetAxis("Horizontal");
			// transform.position += x * maxSpeed * transform.right * Time.deltaTime;
			rigidBody2D.velocity = new Vector2(x * maxSpeed, rigidBody2D.velocity.y);

			//condição para animação
			if (Input.GetAxis("Horizontal") != 0) {
				animator.SetBool("taAndando", true);
			}
			else {
				animator.SetBool("taAndando", false);
			}



			if (Input.GetButtonDown("Jump") && !isJumping && maximoPulos < 2){

					isJumping = true;
					//[0,1] adicionando o valor do jump no y indo pra cima
					rigidBody2D.velocity += Vector2.up * jumpSpeed;
					animator.SetBool("taPulando", true);

			}





		}

		private void OnCollisionEnter2D(Collision2D other) {
			//Verifica a normal do primeiro collider que o jogador bater
			//Caso a normal estiver apontada para cima, quer dizer que ele está no chão e não em uma parede (normal é horizontal)

			if(other.contacts[0].normal == Vector2.up){
				isJumping = false;
				animator.SetBool("taPulando", false);
			}

			if(other.gameObject.CompareTag("Enemy")){
				vida -=10;
				vidaTexto.text = "Vidas: " + vida;
				animator.SetBool("taSofrendo", true);

			}


		}

	}
