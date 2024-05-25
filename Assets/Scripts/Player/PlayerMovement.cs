using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float _moveSpeed;

    [Header("Jump")]
    [SerializeField] private float _jumpPower;
    public bool IsGrounded = false;

    [Header("References")]
    [SerializeField] private Rigidbody _rb;


    private void Update()
    {
        if (IsGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space)) StartJump();
            if (Input.GetKeyUp(KeyCode.Space)) ReleaseJump();
        }
        MovePlayer();
    }

    private void MovePlayer()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 move = new Vector3(x, 0.0f, y).normalized * _moveSpeed * Time.deltaTime;
        Vector3 newPosition = _rb.position + move;
        _rb.MovePosition(newPosition);
    }

    private void StartJump()
    {
        
    }

    private void ReleaseJump()
    {
        _rb.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
    }
}
