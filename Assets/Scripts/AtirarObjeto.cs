using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarObjeto : MonoBehaviour
{

    public Rigidbody2D pena;
    public float velocityPena;
    public Transform positionPena;
    public float timeThrowPena = 2f;
    public float time = 2f;

    // Start is called before the first frame update
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
      Rigidbody2D clone;
      clone = Instantiate(pena, positionPena.transform.position, transform.rotation);
      clone.velocity = transform.TransformDirection(Vector2.right*velocityPena);
    }


}
