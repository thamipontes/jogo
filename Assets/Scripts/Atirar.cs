using PartII;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    public GameObject projectil;

    public Transform positionProjectil;

    public float velocidadeProjetil;

    public float timePassado;
    public float tempoEspera;

    private void Update()
    {
        timePassado += Time.deltaTime;
    }

    public void Dispara()
    {
        if (timePassado >= tempoEspera)
        {
            AtirarProjetil();
            timePassado = 0;
        }
    }

    public void AtirarProjetil()
    {
        GameObject projetil = Instantiate(projectil, positionProjectil.transform.position, transform.rotation);

        Vector3 moveRight = gameObject.GetComponent<PlayerMovimentation>().transform.localScale;

        if (moveRight.x == 1)
        {
            projetil.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeProjetil, 0);
        }
        else
        {
            projetil.GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidadeProjetil, 0);
        }
    }
}