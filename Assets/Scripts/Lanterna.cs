using System.Collections;
using System.Collections.Generic;
using PartII;
using UnityEngine;


public class Lanterna : MonoBehaviour
{
    private UnityEngine.Rendering.Universal.Light2D light2D;
    public int velocidadeCarga;
    public GameObject gameOver;
    void Awake()
    {
        light2D = GetComponent<UnityEngine.Rendering.Universal.Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (light2D.enabled)
        {
            light2D.intensity -= (Time.deltaTime)/velocidadeCarga;
        }

        if (light2D.intensity < 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject.GetComponentInParent<PlayerMovimentation>());
        }
    }
}
