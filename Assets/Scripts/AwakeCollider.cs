using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeCollider : MonoBehaviour
{
    public GameObject objeto;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            objeto.SetActive(true);
            Debug.Log("collider");
        }
    }
}
