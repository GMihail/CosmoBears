using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LerpRing : MonoBehaviour
{
    public Vector3 _startPosition;
    public Vector3 _endPosition;
    private Vector3 _backPosition;
    private Vector3 _finalPosition;
    public float _step;
    private float _progress;
    //private float _backProgress;
    public Vector3 _scale;
    public Vector3 _newScale;
    private Vector3 _backScale;
    [SerializeField] private bool _direction = true;

    private void Awake()
    {
        _finalPosition = _endPosition;
        _startPosition = transform.position;
        _backPosition = _startPosition;
        _scale = transform.localScale;
        _backScale = _scale;
    }
    private void Update()
    {   if (_direction == true)
        {
            if (transform.position.y != _endPosition.y)
            {
                transform.position = Vector3.Lerp(transform.position, _finalPosition, _progress);
                _progress += _step;
                transform.localScale = Vector3.Lerp(transform.localScale, _newScale, _progress);
                _progress += _step;
            }
            if (transform.position.y == _endPosition.y)
            {
                _direction = false;
                _progress = 0;
            }
        }
        if (_direction == false)
        {
            if (transform.position.y != _backPosition.y)
            {
                transform.position = _backPosition;
               // _progress += _step;
                transform.localScale = _backScale;
                //_progress += _step;
            }
            if (transform.position == _startPosition)
            { 
                _direction = true;
                //_progress = 0;
            }
        }
    }


}
