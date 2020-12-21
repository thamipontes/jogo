using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
        /*Como estou colocando como variável publica, ele aparecerá o campo para ser completado
        no Unity */
        public Vector2 start; //Posição inicial do inimigo
        public Vector2 end; //Posição final do inimigo
        public float speed = 2.0f;




        private Vector3 direction;
        private float directionFactor = 1; //Variável que trocará a direção

        private void Start()
        {
            transform.position = new Vector3(start.x, start.y, transform.position.z);
            direction = (end - start).normalized;
        }

        void Update()
        {

            //transform.position += Vector3.right*speed*directionFactor;
            
            //Posição atual dp inimigo a cada frame
            transform.position += directionFactor * direction * speed * Time.deltaTime;            

            //Se a posição que o inimigo tá agora e a posição final definida 
            //Não coloca igual por ser um float a precisão não é boa.
            if (Vector2.Distance(transform.position, end) < 0.08f)
            {
                directionFactor = -1.0f;
            }
            else if (Vector2.Distance(transform.position, start) < 0.08f)
            {
                directionFactor = 1.0f;
            }

        }

}
