using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarObjeto : MonoBehaviour
{
    public GameObject pena;             // objeto pena
    public Transform positionPena;      // posição pena
    public float timeThrowPena = 2f;    // tempo de chec
    public float time = 2f;

    void Start()
    {
        // InvokeRepeating();
    }

    // Update is called once per frame
    void Update()
    {
      time += Time.deltaTime;
      if(time >= timeThrowPena)
      {
        InstantiatePena();
        time = 0f;
      }


    }

    private void InstantiatePena()
    {
      // GameObject clone;
      Instantiate(pena, positionPena.transform.position, transform.rotation);
      // clone.velocity = transform.TransformDirection(Vector2.right*velocityPena);
      // StartCoroutine(TempoPena(clone));
    }
    //
    // IEnumerator TempoPena(GameObject clone)
    // {
    //   yield return new WaitForSecondsRealtime(2f);
    //   Destroy(clone);
    // }

}
