using System;
using System.Collections;
using System.Collections.Generic;
using PartII;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    public GameObject projectil;

    public Transform positionProjectil;

    public float velocidadeProjetil;
    

    public void AtirarProjetil()
    {
        Instantiate(projectil, positionProjectil.transform.position, transform.rotation);
        
        bool moveRight = gameObject.GetComponent<PlayerMovimentation>().moveRight;
        if (moveRight)
        {
            projectil.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeProjetil,0);
        }
        else
        {
            projectil.GetComponent<Rigidbody2D>().velocity = new Vector2(-1*velocidadeProjetil,0);
        }
    }
}
