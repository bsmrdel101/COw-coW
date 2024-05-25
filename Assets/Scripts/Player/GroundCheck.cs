using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private LayerMask _layer;
    [SerializeField] PlayerMovement _playerMovement;


    private void OnTriggerEnter(Collider col)
    {
        Debug.Log(col);
        if ((_layer.value & (1 << col.gameObject.layer)) != 0)
            _playerMovement.IsGrounded = true;
    }

    private void OnTriggerExit(Collider col)
    {
        if ((_layer.value & (1 << col.gameObject.layer)) != 0)
            _playerMovement.IsGrounded = false;
    }
}
