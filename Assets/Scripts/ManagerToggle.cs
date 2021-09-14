using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManagerToggle : ManagerRandomNumber
{
    public TextMeshProUGUI numero;
    public Toggle[] toggle = new Toggle[5];
    public bool isActive = true;
    public int numeroSelecionado;

    private int canPressToggle = 1;

    public void Start()
    {
        for(int i = 0; i < toggle.Length; i++)
        {
            toggle[i].onValueChanged.AddListener(delegate {PressionaToggle();});
        }
    }


    private void PressionaToggle()
    {
        for(int j = 0; j < toggle.Length; j++){
            if(toggle[j].isOn == true && canPressToggle == 1) {
                numero.text = (j+1) + "";
                numeroSelecionado = j+1;
                canPressToggle = 0;
                for(int i = 0; i < toggle.Length; i++)
                {
                    toggle[i].interactable = false;
                }
                isActive = false;
            }
        }
    }

    public void DesativaColuna(){
        isActive = false;
        for(int i = 0; i < toggle.Length; i++)
        {
            toggle[i].interactable = false;
        }
    }

    public void ReiniciaToggle(){
        isActive = true;
        numero.text = "0";
        canPressToggle = 1;
        for(int i = 0; i < toggle.Length; i++){
            toggle[i].isOn = false;
            toggle[i].interactable = true;
        }
    }

}
