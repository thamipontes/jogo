using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pena : MonoBehaviour
{
  HUDControl hcontrol;
  public float velocityPena;
  public Rigidbody2D rb;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    Destroy(gameObject, 2f);
  }

  void Update()
  {
    // rb.velocity = transform.TransformDirection(Vector2.right*velocityPena);
    if(rb != null)
    {
        rb.velocity = transform.up*(-1)*velocityPena;
    }
  }

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
