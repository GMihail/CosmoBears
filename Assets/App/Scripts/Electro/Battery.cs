using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : Energy
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.TryGetComponent(out InEnergy inEnergy))
        {
            inEnergy.Wire.Power = Power - 1;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.TryGetComponent(out InEnergy inEnergy))
        {
            inEnergy.Wire.Power = 0;
        }
    }
}

