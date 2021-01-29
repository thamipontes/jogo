using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pena : MonoBehaviour
{
  public GameObject pena;
  HUDControl hcontrol;

  private void OnCollisionEnter2D(Collision2D other)
  {
    var target = other.gameObject;
    if(target.CompareTag("Player"))
    {
      // tira o rigidbody para o objeto parar na colisão e não obedecer a gravidade
      Destroy(GetComponent<Rigidbody2D>());
      Destroy(gameObject, 0.2f);

      var healthPlayer = target.GetComponent<PlayerHealth>();
      hcontrol.TirarVida();
      healthPlayer.Damage();



    }
  }
}
