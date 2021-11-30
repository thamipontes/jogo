using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chefao : MonoBehaviour
{
    public GameObject chefao;
    public Transform _positionChefao, cavaloPosition;
    private Animator _anim;
    public GameObject cavalo;
    public float posX, posY, cavY;
    private void Awake()
    {
        cavaloPosition = cavalo.GetComponent<Transform>();
        // _movimentacao = GetComponent<PlatformMovement>();

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(chefao, _positionChefao.transform.position, transform.rotation);
            _anim = chefao.GetComponent<Animator>();
            _anim.SetBool("parado", true);
            transform.position = new Vector3(posX, posY, transform.position.z);
            cavaloPosition.transform.position = new Vector3(posX, cavY, cavaloPosition.transform.position.z);
            Destroy(gameObject.GetComponent<BoxCollider2D>());

        }
    }
    
}
