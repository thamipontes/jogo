using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlat : MonoBehaviour
{
    //Rigidbody2D rigidbody2D;

    public Vector3 start;
    public Vector3 end;
    public Vector3 next;

    public float speed;


    

    // Start is called before the first frame update
    void Start()
    {
        next = end;
    }

    void Awake() {
        //rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.MoveTowards(start, next, speed*Time.deltaTime );

        if(Vector3.Distance(start, next) <= 0.1f){
            next = next.y != start.y ? start : end;
        }
    }

    /*
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
        
            transform.position = new Vector3(transform.position.x, end.y, transform.position.z);
        }
    }
    */
}
