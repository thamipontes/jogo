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

    public float posXMax = 29f;
    public float posXMin = -10f;
    public float posYMin = 0.3f;


    void FixedUpdate()
    {
        //Graduamente muda um vetor em direção a um ponto desejado à medida do tempo
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y + deltaY, ref velocity.y,
            smoothTimeY);

        /* Confere se o player está dentro desse intervalo, caso esteja, a câmera
         * recebe a mesma posisção do player
         */
        if (posX < posXMax && posX > posXMin && posY > posYMin)
        {
            transform.position = new Vector3(posX, posY, transform.position.z);
        }
        //Caso contrário recebe valores fixos, ou seja, para que não passe as posições pré-definidas
        else
        {
            if (posY < posYMin)
            {
                posY = posYMin;
            }

            if (posX < posXMin)
            {
                posX = posXMin;
            }

            if (posX > posXMax)
            {
                posX = posXMax;
            }

            transform.position = new Vector3(posX, posY, transform.position.z);
        }
    }
}