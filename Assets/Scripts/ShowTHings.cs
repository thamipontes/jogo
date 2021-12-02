using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTHings : MonoBehaviour
{
    public GameObject botao;

    private void OnTriggerEnter2D(Collider2D other)
    {
        botao.gameObject.SetActive(true);
    }
}