using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutEnergy : MonoBehaviour
{
    public Wire Wire;
    private void Start()
    {
        Wire = GetComponentInParent<Wire>();
    }
}
