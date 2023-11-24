using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Outline))]
public class GlovesInteract : MonoBehaviour
{
    [SerializeField] private UnityEvent _useEvent;
    public UnityEvent EventBtn
    {
        get
        {
            return _useEvent;
        }
    }
}
