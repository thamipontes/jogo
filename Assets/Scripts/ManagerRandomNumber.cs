using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManagerRandomNumber : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] sinaisCanvas = new TextMeshProUGUI[5];
    [SerializeField] ManagerToggle[] managerToggle = new ManagerToggle[5];

    public GameObject vitoria, fase1, fase2, fase3, fase4, fase5, errou, acertou; 

    public int resultadoEtapa4, resultadoEtapa5;
    public float time = 0.5f;
    
    private char[] operadores = {'+', '-', '*'};
    private int resultado, estado = 1;
    private bool tudoPressionado = false;
    private bool resultadoCorreto;
    private int sinaisNegativos = 0;

    void Start(){
        InicializaEstado();
    }

    void Update(){
        tudoPressionado = !(managerToggle[0].isActive || managerToggle[1].isActive || managerToggle[2].isActive || managerToggle[3].isActive || managerToggle[4].isActive);
        if(tudoPressionado) {
            Time.timeScale = 0;
            GerenciaLevel();
            Time.timeScale = 1;
            tudoPressionado = false;
        }
        Debug.Log(estado);
    }

    public void GerenciaLevel(){
        Debug.Log("AAAAAAAAAA");

        if(ValidaResultado()){
            acertou.SetActive(true);
            StartCoroutine(AcertouErrouTimer());
            estado++;
            if(estado == 6) {
                PlayerPrefs.SetInt("Conquista 1", 1);
                PlayerPrefs.Save();
                vitoria.SetActive(true);
                // string scene = "Ada Lovelace";
                // GoToScene go = new GoToScene();
                // go.ChangeScene(scene);
            }
        }else { 
            errou.SetActive(true);
            StartCoroutine(AcertouErrouTimer());
        }

        for(int i = 0; i < 5; i++){
            managerToggle[i].ReiniciaToggle();
        }

        InicializaEstado();

    }

    private string SelecionaOperador(){
        string sinal = "";
        if(estado < 4){
            sinal = operadores[Random.Range(0,2)] + "";
        }
        if(sinal == "-"){
            sinaisNegativos++;
        }
        return sinal;
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
        if(estado < 4){
            for(int i = 0; i < 4; i++){
                if(sinaisCanvas[i].text=="+"){
                    resultado += managerToggle[i+1].numeroSelecionado;
                } else if(sinaisCanvas[i].text=="-"){
                    resultado -= managerToggle[i+1].numeroSelecionado;
                } else if(sinaisCanvas[i].text=="*"){
                    resultado *= managerToggle[i+1].numeroSelecionado;
                }
            }
        } else if(estado == 4){
            resultado = managerToggle[0].numeroSelecionado
                        + managerToggle[1].numeroSelecionado
                        - managerToggle[2].numeroSelecionado
                        * managerToggle[3].numeroSelecionado;
        } else {
            resultado = managerToggle[0].numeroSelecionado
                        + managerToggle[1].numeroSelecionado
                        - (managerToggle[2].numeroSelecionado
                        * managerToggle[3].numeroSelecionado)
                        + managerToggle[4].numeroSelecionado;
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
                fase1.SetActive(true);
                break;
            case 2:
                sinaisNegativos = 0;
                sinaisCanvas[0].text = SelecionaOperador();

                for(int i = 1; i < 4; i++){
                    sinaisCanvas[i].text = "";
                }
                sinaisCanvas[4].text = SelecionaValorResultado(sinaisNegativos,2).ToString("0");
                for(int a = 2; a < 5; a++)
                {
                    managerToggle[a].DesativaColuna();
                }
                fase2.SetActive(true);
                break;
            case 3:
                sinaisNegativos = 0;
                sinaisCanvas[0].text = SelecionaOperador();
                sinaisCanvas[1].text = SelecionaOperador();
                sinaisCanvas[2].text = SelecionaOperador();
                sinaisCanvas[3].text = "";
                sinaisCanvas[4].text = SelecionaValorResultado(sinaisNegativos,4).ToString("0");

                managerToggle[4].DesativaColuna();
                fase3.SetActive(true);
                break;
            case 4:
                sinaisCanvas[0].text = "+";
                sinaisCanvas[1].text = "-";
                sinaisCanvas[2].text = "*";
                sinaisCanvas[3].text = "";
                sinaisCanvas[4].text = resultadoEtapa4 + "";

                managerToggle[4].DesativaColuna();
                fase4.SetActive(true);
                break;
            case 5:
                sinaisCanvas[0].text = "+";
                sinaisCanvas[1].text = "-";
                sinaisCanvas[2].text = "*";
                sinaisCanvas[3].text = "+";
                sinaisCanvas[4].text = resultadoEtapa5 + "";
                fase5.SetActive(true);
                break;
        }
    }

    IEnumerator AcertouErrouTimer()
    {
        yield return new WaitForSecondsRealtime(time);
        acertou.SetActive(false);
        errou.SetActive(false);

    }

}
