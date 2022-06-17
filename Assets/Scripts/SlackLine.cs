
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlackLine : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    private Renderer _slackLine; 
    public float timeForDisappear = 0.5f;
    [SerializeField] SlackLineMov _slackLineMov;
    
    void Start()
    {
        _slackLine = GetComponent<Renderer>();
        _slackLineMov.enabled = false;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Disappear();
        }
    }

    public void Disappear()
    {
        StartCoroutine(DisappearTime());
    }

    IEnumerator DisappearTime()
    {
        Debug.Log("Entrei");
        yield return new WaitForSecondsRealtime(timeForDisappear);
        _slackLine.enabled = false;
        _slackLineMov.enabled = true;
        Debug.Log("Sai");
    }
}
