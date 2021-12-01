using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArma : MonoBehaviour
{

    public float distancia;
    public float tempoDeVida;

    public LayerMask layerInimigo;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestruirProjetil", tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D bateu = Physics2D.Raycast(transform.position, transform.right, distancia, layerInimigo);
        if (bateu.collider != null)
        {
            if (bateu.collider.CompareTag("Water"))
            {
                bateu.collider.GetComponent<ChefaoHealth>().Damage();
            }
        }
    }

    void DestruirProjetil()
    {
        Destroy(gameObject);
    }
}
