using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moedaFinal : MonoBehaviour
{
    //Declarar o objeto jogador
    public GameObject jogador;

    //Declarar a posição do eixo X inicial do jogador
    public float jogadorInicialX = -12.44f;

    //Declarar a posição do eixo y inicial do jogador
    public float jogadorInicialY = 2.78f;

    //Declarar a posição inicial da câmera no eixo X
    public float cameraInicialX = -3.66f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {

        //Setando na variavel a posição do jogador 
        var jogadorPosicao = jogador.transform.position;
        jogador.transform.position = new Vector3(jogadorInicialX, jogadorInicialY, jogadorPosicao.z);

        var cameraPosicao = Camera.main.transform.position;
        Camera.main.transform.position = new Vector3(cameraInicialX, cameraPosicao.y, cameraPosicao.z);

    }

}
