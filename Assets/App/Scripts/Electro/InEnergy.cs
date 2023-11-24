using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InEnergy : MonoBehaviour
{
    public Wire Wire;
    private void Start()
    {
        Wire = GetComponentInParent<Wire>();
    }
    
}
