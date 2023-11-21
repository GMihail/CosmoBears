using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugInteractObject : MonoBehaviour
{
    [SerializeField] private string _text;
    
    public void Invoke()
    {
        Destroy(gameObject);
        Debug.Log(_text);
    }
}
