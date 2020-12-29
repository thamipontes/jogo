using System;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float minX = 0;
    public float maxX = 30;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x > minX && player.transform.position.x < maxX)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
