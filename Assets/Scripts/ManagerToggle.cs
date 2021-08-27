using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManagerToggle : MonoBehaviour
{
    public TextMeshProUGUI numero;
    public Toggle[] toggle = new Toggle[5];
    public bool isActive = true;
    public int numeroSelecionado;

    private int canPressToggle = 1;

    private void Update()
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

}
