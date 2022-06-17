using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FecharJogo : MonoBehaviour
{
    public SalvarPosicao _salvarPosicao;

    private HUDControl _hudControl;

    public float x = -9f;
    public float y = 1.3f;

    public void FechaJogo()
    {
        _salvarPosicao.SalvarLocalizacao(x, y);
        Coins.coins = 0;
        Coins.SalvaMoedas();
        HUDControl.gasolinaBarScale.x = 0;
        HUDControl.SalvaGasolina();
        Application.Quit();
    }
}
