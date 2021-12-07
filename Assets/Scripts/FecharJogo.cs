using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FecharJogo : MonoBehaviour
{
    public SalvarPosicao _salvarPosicao;

    public void FechaJogo()
    {
        _salvarPosicao.SalvarLocalizacao(-9f, 1.3f);
        Application.Quit();
    }
}
