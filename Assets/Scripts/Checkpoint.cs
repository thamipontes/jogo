using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public SalvarPosicao _salvarPosicao;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        _salvarPosicao.SalvarLocalizacao();
    }
}
