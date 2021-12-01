using UnityEngine;

public class Pena : MonoBehaviour
{
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

  private void OnTriggerEnter2D(Collider2D other)
  {
    var target = other.gameObject;
    if(target.CompareTag("Player"))
    {
      // tira o rigidbody para o objeto parar na colisão e não obedecer a gravidade
      if(gameObject != null)
      {
          Destroy(GetComponent<Rigidbody2D>());
          Destroy(gameObject);
      }

      var healthPlayer = target.GetComponent<PlayerHealth>();
      healthPlayer.Damage();

    }
  }
}
