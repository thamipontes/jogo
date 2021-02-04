using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConversationAda : MonoBehaviour
{
    [SerializeField] Tester _tester;

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.CompareTag("Player"))
      {
        _tester.StartConvo();
      }
    }
}
