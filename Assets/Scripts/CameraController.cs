using UnityEngine;

/*
 * Classe: CameraController
 * Descrição: Controla a movimentação da câmera de acordo com a posição do player
 */
public class CameraController : MonoBehaviour
{
    //Atributo do objeto player
    public GameObject player;

    //Atributo que possuirá as duas coordenadas da velocidade
    private Vector2 velocity;

    //Tempo de espera para atingir uma posição no eixo X
    public float smoothTimeY;

    //Tempo de espera para atingir uma posição no eixo y
    public float smoothTimeX;
    public float deltaY;


    void FixedUpdate()
    {
        //Graduamente muda um vetor em direção a um ponto desejado à medida do tempo
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y + deltaY, ref velocity.y,
            smoothTimeY);

        /* Confere se o player está dentro desse intervalo, caso esteja, a câmera
         * recebe a mesma posisção do player
         */
        if (posX < 28 && posX > -10 && posY > 0.3)
        {
            transform.position = new Vector3(posX, posY, transform.position.z);
        }
        //Caso contrário recebe valores fixos, ou seja, para que não passe as posições pré-definidas
        else
        {
            if (posY < 0.3)
            {
                posY = 0.3f;
            }

            if (posX < -10)
            {
                posX = -10;
            }

            if (posX > 29)
            {
                posX = 29f;
            }

            transform.position = new Vector3(posX, posY, transform.position.z);
        }
    }
}