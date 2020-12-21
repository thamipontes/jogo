using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentCamera : MonoBehaviour
{

    //Declarando o objeto jogador
    public GameObject jogador;

    //Posição que minha camera deve começar no eixo X
    public float min = -3.66f;

    //Posição que minha camera deve terminar no eixo X
    public float max = 30.12f;


       void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Setando em uma variavel a posição do jogador no eixo x
        var jogadorPosicaoX = jogador.transform.position.x; 

        //A posição do jogador no eixo X deve ser maior que o mínimo adotado e menor que o máximo adotado
        if( jogadorPosicaoX > min && jogadorPosicaoX < max){
            
            //Transform.position é da camera, visto que criamos o script e fixamos na câmera
            //Setamos para a posição da câmera em X a mesma posição do jogador e pra y e z mantemos as posições da camera normalmente
            transform.position = new Vector3(jogadorPosicaoX, transform.position.y, transform.position.z);
        }
    }
}
