using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private KeyCode _jumpKeyCode;
    [SerializeField] private LayerMask _groundLayerMask;

    private bool isGrounded;

    private void Update()
    {
        if (Input.GetKeyDown(_jumpKeyCode))
            JumpUp();

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
}