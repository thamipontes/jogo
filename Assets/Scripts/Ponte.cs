using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ponte : MonoBehaviour
{
    // Start is called before the first frame update


    private Rigidbody2D _rigidbody;
    public float timeForFall = 0.5f;
    [SerializeField] PonteMov _ponteMov;
    void Start()
    {
        _ponteMov.enabled = false;

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
        }
    }

    public void Fall()
    {
        MusicManager.playSound("PONTE");
        StartCoroutine(FallTime());

    }

    IEnumerator FallTime()
    {
        Debug.Log("Entrei");
        yield return new WaitForSecondsRealtime(timeForFall);
        _ponteMov.enabled = true;
        Debug.Log("Sai");

    }
}
