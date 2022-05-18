using System.Collections;
using UnityEngine;

public class TremFantasma : MonoBehaviour
{
    public GameObject trem;
    public Transform _positionTrem;
    public float speed;

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject tremInstanciado = Instantiate(trem, _positionTrem.transform.position, transform.rotation);
            tremInstanciado.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
            StartCoroutine(DestruirObjeto(tremInstanciado));
        }

    }
    
    IEnumerator DestruirObjeto (GameObject tremInstanciado)
    {
        yield return new WaitForSeconds(2);
        Destroy(tremInstanciado);
        
    }

}
