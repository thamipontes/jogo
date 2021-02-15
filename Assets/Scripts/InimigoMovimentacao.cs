using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Classe: InimigoMovimentacao
 * Descrição: Controla a movimentação dos inimigos
 */
public class InimigoMovimentacao : MonoBehaviour
{
    //Coordenadas da posição inicial
    public Vector2 start;

    //Coordenadas da posição final
    public Vector2 end;

    //Velocidade inimigo
    public float speed;

    //Direção inimigo
    private Vector3 direction;

    private float directionFactor = 1;

    //Atributo de Rigidbody
    private Rigidbody2D _rigidbody2D;

    //Escala da imagem do inimigo
    private float originalXScale;

    void Start()
    {
        originalXScale = transform.localScale.x;
        transform.position = new Vector3(start.x, start.y, transform.position.z);
        direction = (end - start).normalized;
    }

    void Update()
    {

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
      Vector3 scale = transform.localScale;
      scale.x = originalXScale*directionFactor;
      transform.localScale = scale;
    }
}
