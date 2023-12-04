using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEditor;

public class ActivateBridge : MonoBehaviour
{
    public bool _buttonPress;
    public GameObject _bridge;
    private void FixedUpdate()
    {
        if (_buttonPress) 
        {
            _bridge.SetActive(true);
        }
        else
        {
            _bridge.SetActive(false);
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

