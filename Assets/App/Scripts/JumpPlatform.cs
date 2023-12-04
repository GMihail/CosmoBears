using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class JumpPlatform : MonoBehaviour
{
    public Rigidbody _player;
    public Transform _referencePoint;
    private Vector3 _jumpVector;
    public float _powerJump;

    private void OnCollisionEnter(Collision collision)
    {
        _jumpVector = _referencePoint.transform.position - _player.transform.position;
        _player.AddForce(_jumpVector * _powerJump, ForceMode.Impulse);
    }
}
