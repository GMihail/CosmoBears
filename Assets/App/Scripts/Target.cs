using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float _climb = 2f;

    public void Commence(float _amout)
    {
        _climb -= _amout;
        if( _climb <= 0f )
        {
            Go();
        }
    }
    void Go()
    {
        Destroy(gameObject);
    }
}
