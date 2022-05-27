using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativateCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objeto;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            objeto.SetActive(false);
        }
    }
}
