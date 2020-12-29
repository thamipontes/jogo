using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalFase : MonoBehaviour
{
    public GameObject player;
    public float playerInitialX = 5f;
    public float playerInitialY = 3f;
    public float cameraInitialX = 0f;

    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {}

    private void OnCollisionEnter2D(Collision2D other)
    {
        player.transform.position = new Vector3(playerInitialX, playerInitialY, player.transform.position.z);
        Camera.main.transform.position = new Vector3(cameraInitialX,Camera.main.transform.position.y,Camera.main.transform.position.z);
    }
}
