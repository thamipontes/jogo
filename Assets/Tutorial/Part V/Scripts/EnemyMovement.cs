using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PartV
{
    public class EnemyMovement : MonoBehaviour
    {
        public Vector2 start;
        public Vector2 end;
        public float speed;

        private Vector3 direction;
        private float directionFactor = 1;

        private void Start()
        {
            transform.position = new Vector3(start.x, start.y, transform.position.z);
            direction = (end - start).normalized;
        }

        void Update()
        {
            transform.position += directionFactor * direction * speed * Time.deltaTime;

            if (Vector2.Distance(transform.position, end) < 0.08f)
            {
                directionFactor = -1.0f;
            }
            else if (Vector2.Distance(transform.position, start) < 0.08f)
            {
                directionFactor = 1.0f;
            }

        }
    }
}