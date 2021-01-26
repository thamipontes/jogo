using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMovimentacao : MonoBehaviour
{

    public Vector2 start;

    public Vector2 end;

    public float speed;

    private Vector3 direction;

    private float directionFactor = 1;

    private Rigidbody2D _rigidbody2D;

    private int directionScale = 1;

    private float originalXScale;

    void Start()
    {
        // _rigidbody2D = GetComponent<Rigidbody2D>();
        // _rigidbody2D.position = new Vector2(start.x, start.y);
        originalXScale = transform.localScale.x;
        transform.position = new Vector3(start.x, start.y, transform.position.z);
        direction = (end - start).normalized;
    }

    void Update()
    {

        //_rigidbody2D.AddForce(direction * directionFactor * speed);
        transform.position += directionFactor * direction * speed * Time.deltaTime;
        if (Vector2.Distance(transform.position, end) < 0.3f)
        {
            directionFactor = -1.0f;
            Flip();
        }
        else if (Vector2.Distance(transform.position, start) < 0.3f)
        {
            directionFactor = 1.0f;
            Flip();
        }
    }

    private void Flip()
    {
      // directionScale *= -1;
      Vector3 scale = transform.localScale;
      scale.x = originalXScale*directionFactor;
      transform.localScale = scale;
    }
}
