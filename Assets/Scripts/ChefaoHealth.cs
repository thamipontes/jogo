using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefaoHealth : MonoBehaviour
{
    public Animator animator;
    public int vidaChefao = 10;
    public 
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    

    // private void OnCollisionEnter2D(Collision2D other)
    // {
    //     if (other.gameObject.CompareTag("Player"))
    //     {
    //         vidaChefao--;
    //         StartCoroutine(damageTime());
    //         
    //         if (vidaChefao <= 1)
    //         {
    //             var parent = transform.GetComponentInParent<GameObject>(); 
    //             Destroy(parent);
    //         }
    //     }
    // }
    //

    public void Damage()
    {
        vidaChefao--;
        StartCoroutine(damageTime());
        
        if (vidaChefao <= 1)
        {
            Destroy(gameObject);
        }
    }
    IEnumerator damageTime()
    {
        animator.SetBool("parado",true);
        // MusicManager.playSound("machucar1");
        yield return new WaitForSecondsRealtime(0.75f);
        animator.SetBool("parado", false);
    }
}
