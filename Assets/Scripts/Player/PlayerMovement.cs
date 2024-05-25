using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    // [SerializeField] private float _moveSpeed;
    private Vector3 _vel = new Vector3();

    [Header("Jump")]
    [SerializeField] private float _jumpPower;

    [Header("Ground Check")]
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _groundDistance = 0.4f;
    [SerializeField] private LayerMask _groundMask;
    private bool _isGrounded;

    [Header("References")]
    [SerializeField] private Rigidbody _rb;


    private void Update()
    {
        _isGrounded = CheckGround();
        if (_isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space)) StartJump();
            if (Input.GetKeyUp(KeyCode.Space)) ReleaseJump();
        }
    }

    private bool CheckGround()
    {
        return Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);
    }

    private void StartJump()
    {
        
    }

    private void ReleaseJump()
    {
        _rb.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
    }
}
