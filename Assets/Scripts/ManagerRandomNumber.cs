using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManagerRandomNumber : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] sinaisCanvas = new TextMeshProUGUI[5];
    [SerializeField] ManagerToggle[] managerToggle = new ManagerToggle[5];

    private char[] operadores = {'+', '-'};
    private int resultado, estado = 1;
    private string sinal;
    private bool tudoPressionado = false;
    private bool resultadoCorreto;

    void Start(){
        InicializaEstado();
    }

    void Update(){
        tudoPressionado = !(managerToggle[0].isActive || managerToggle[1].isActive || managerToggle[2].isActive || managerToggle[3].isActive || managerToggle[4].isActive);
        if(tudoPressionado){
            if(!ValidaResultado()){
                for(int i = 0; i < 5; i++){
                    managerToggle[i].ReiniciaToggle();
                }
            } else{
                estado++;
            }
            InicializaEstado();
        }
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

    public bool ValidaResultado(){
        int resultado = managerToggle[0].numeroSelecionado;
        for(int i = 0; i < 4; i++){
            if(sinaisCanvas[i].text=="+"){
                resultado += managerToggle[i+1].numeroSelecionado;
            } else if(sinaisCanvas[i].text=="-"){
                resultado -= managerToggle[i+1].numeroSelecionado;
            } else if(sinaisCanvas[i].text=="*"){
                resultado *= managerToggle[i+1].numeroSelecionado;
            }
        }
        if(resultado==(int.Parse(sinaisCanvas[4].text))){
            return true;
        } else {
            return false;
        }
    }

    public void InicializaEstado(){
        Debug.Log("teste");
        switch (estado){
            case 1:
                sinaisCanvas[0].text = operadores[0].ToString();
                for(int i = 1; i < 4; i++){
                    sinaisCanvas[i].text = "";
                }
                sinaisCanvas[4].text = SelecionaValorResultado(0,2).ToString("0");
                for(int a = 2; a < 5; a++)
                    managerToggle[a].DesativaColuna();
                break;
        }
    }
}
