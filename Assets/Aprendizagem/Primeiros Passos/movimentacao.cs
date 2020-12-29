using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour
{
    public float maxSpeed = 5f;
    public float jumpSpeed = 5f;
    private Rigidbody2D _rigidbody2D;
    private bool isJumping = false;

    void Start()
    {

    }

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // "while"
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        //transform.position += x * maxSpeed * transform.right;
        _rigidbody2D.velocity = new Vector2(x * maxSpeed, _rigidbody2D.velocity.y);

        var jump = Input.GetAxis("Jump");
        if(jump > 0.5f && !isJumping)
        {
            isJumping = true;
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jump * jumpSpeed);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // if(other.contacts[0].normal == Vector2.up)
        // {
        isJumping = false;
        // }
    }
}
