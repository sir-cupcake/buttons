using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemant : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _jumpForce;
    [SerializeField] private KeyCode _jumpKeyCode;
    [SerializeField] private LayerMask _groundLayerMask;
    [SerializeField] private LayerMask _doorLayerMask;
        private bool isGrounded;

    private void Update()
    {
        if (Input.GetKeyDown(_jumpKeyCode))
        {
            JumpUp();
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            Move();
        }
    }
    private void JumpUp()
    {
        if (isGrounded)
        {
            _rb.AddForce(_jumpForce * Vector2.up, ForceMode2D.Impulse);
            isGrounded = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if ((_groundLayerMask.value & (1 << col.gameObject.layer)) > 0)
        {
            isGrounded = true;
        }
    }
    private void Move()
    {
        _rb.velocity = Vector2.right * _speed * Input.GetAxis("Horizontal");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((_groundLayerMask.value & (1 << collision.gameObject.layer)) > 0)
        {
            isGrounded = true;
        }
    }
    
}
 