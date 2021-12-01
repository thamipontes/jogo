using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private ParticleSystem _particleSystem;
    
    private void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
    }
    
    
    void Update()
    {
        if (_particleSystem.isStopped)
        {
            StartCoroutine(timeToPlay());
        }
    }
    
    IEnumerator timeToPlay()
    {
        yield return new WaitForSecondsRealtime(0.75f);
        _particleSystem.Play();
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.layer == 3)
        {
            var healthPlayer = other.gameObject.GetComponent<PlayerHealth>();
            healthPlayer.Damage();
        }
    }
}
