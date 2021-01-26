using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PonteMov:MonoBehaviour
    {

        
        public float speed;
        


        void Update()
        {
            //_rigidbody2D.AddForce(direction * directionFactor * speed);
            transform.position +=  Vector3.down * speed * Time.deltaTime;
           
        }
        
        
    }
