using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarObjeto : MonoBehaviour
{
    //Objeto da pena
    public GameObject pena;
    //Posição da pena
    public Transform positionPena;
    //Tempo de espera para lançar uma nova pena
    public float timeThrowPena = 2f;
    //Tempo percorrido pelo jogo
    public float time = 2f;
    
    /*
     * Nome: Update
     * Parâmetros: vazio
     * Descrição: função chamada pelo Unity a cada frame
     */
    void Update()
    {
      //Recebe o tempo percorrido pelo jogo
      time += Time.deltaTime;
      
      /*
       * Caso o tempo percorrido pelo jogo for maior ou igual ao tempo de espera
       * para lançar um nova pena, instância-se uma pena e zera o atributo time
       * para poder iniciar a contagem novamente de tempo percorrido dentro do jogo para
       * instanciar uma nova pena.
       */
      if(time >= timeThrowPena)
      {
        InstantiatePena();
        time = 0f;
      }


    }
    
    
    /**/
    private void InstantiatePena()
    {
        Instantiate(pena, positionPena.transform.position, transform.rotation);
    }


}
