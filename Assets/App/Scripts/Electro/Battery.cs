using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Battery : Energy
{
    [SerializeField] private TMP_Text _energyText;

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
    private void Update()
    {
        _energyText.text = Power.ToString();
    }
}

