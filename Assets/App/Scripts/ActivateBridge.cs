using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEditor;

public class ActivateBridge : MonoBehaviour
{
    public Vector3 _startPosition;
    public Vector3 _endPosition;
    public float _step;
    private float _progress;
    [SerializeField] private bool _buttonPress = false;

    private void Start()
    {
        transform.position = _startPosition;
    }
    private void FixedUpdate()
    {
        if (_buttonPress)
        {
            transform.position = Vector3.Lerp(_startPosition, _endPosition, _progress);
            _progress += _step;
        }
    }
    private void OpenBridge()
    {
        _buttonPress = true;
    }
    private void CloseBridge() 
    {
        _buttonPress = false;
    }
}

