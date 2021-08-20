using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerRandomNumber : MonoBehaviour
{
    [SerializeField] Text[] sinaisCanvas = new Text[5];

    private char[] operadores = {'+', '-'};
    private int resultado, estado = 1;
    private string sinal;

    void Start(){
        switch (estado){
            case 1:
                sinaisCanvas[0].text = operadores[0].ToString();
                for(int i = 1; i < 4; i++){
                    sinaisCanvas[i].text = "";
                }
                sinaisCanvas[4].text = SelecionaValorResultado(0,2).ToString("0");
                break;
        }        
    }

    void Update(){

    }

    private void SelecionaOperador(int quantOperador){
        if(estado < 4){
            sinal = operadores[Random.Range(0,1)] + "";
        }
    }

    public int SelecionaValorResultado(int numeroSinaiNeg, int numeroEspacos){
        
        int valorMaximo = 5*(numeroEspacos - numeroSinaiNeg) - numeroSinaiNeg;
        int valorMinimo;
        if(numeroSinaiNeg == 0){
            valorMinimo = numeroEspacos;
        } else {
            valorMinimo = 0;
        }

        return Random.Range(valorMinimo, valorMaximo);
    }
}
