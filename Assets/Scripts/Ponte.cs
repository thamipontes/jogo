using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ponte : MonoBehaviour
{
    // Start is called before the first frame update


    private Rigidbody2D _rigidbody;
    public float timeForFall = 0.5f;
    void Start()
    {

        //transform.position = new Vector3(start.x, start.y, transform.position.z);
        //_rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Fall();
            _rigidbody = GetComponent<Rigidbody2D>();

        }
    }

    public void Fall()
    {
        StartCoroutine(FallTime());
    }

    IEnumerator FallTime()
    {
        Debug.Log("Entrei");
        yield return new WaitForSecondsRealtime(timeForFall);
        _rigidbody.gravityScale = 10f;
        Debug.Log("Sai");

    }
}
