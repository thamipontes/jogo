using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pena : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D other)
  {
    if(other.gameObject.CompareTag("Player"))
    {
      // tira o rigidbody para o objeto parar na colisão e não obedecer a gravidade
      Destroy(GetComponent<Rigidbody2D>());
      Destroy(gameObject,0.2f);
    }
  }
}
