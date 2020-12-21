using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armadilha : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject jogador;
    public float jogadorInicialX = -12.44f;
   
    public float jogadorInicialY = 2.78f;
    
    public float cameraInicialX = -3.66f;



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
