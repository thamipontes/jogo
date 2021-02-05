using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoPena : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D other)
  {
    var target = other.gameObject;
    if(target.CompareTag("Player"))
    {
      Destroy(gameObject, 0.2f);

    }
  }
}
