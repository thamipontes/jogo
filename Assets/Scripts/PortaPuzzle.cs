using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaPuzzle : MonoBehaviour
{
    public Animator _animator;

    public GoToScene _goToScene;

    public string scene;

    public float posicaoX = 22f;

    public float posicaoY = 1.5f;

    private HUDControl hudControl;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<SalvarPosicao>().SalvarLocalizacao(posicaoX, posicaoY);
            _animator.SetBool("abrindo", true);
            Coins.SalvaMoedas();
            HUDControl.SalvaGasolina();
            Invoke("goToScena", 0.8f);
        }

    }

    void goToScena()
    {
        _goToScene.ChangeScene(scene);
    }


}
