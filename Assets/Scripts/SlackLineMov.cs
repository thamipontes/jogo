using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlackLineMov : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.position +=  Vector3.down * speed * Time.deltaTime;
    }
}
