using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDamage : MonoBehaviour
{
    private ParticleSystem _particleSystem;
    
    private void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
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