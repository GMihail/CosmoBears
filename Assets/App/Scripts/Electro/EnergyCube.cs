using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnergyCube : Energy
{
    [SerializeField] private TMP_Text _debugText;

   
    private void Update()
    {
        _debugText.text = $"{Power}";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out OutEnergy outEnergy))
        {
           Power = outEnergy.Wire.Power-1;
        }
        if (collision.collider.TryGetComponent(out InEnergy inEnergy))
        {
            Debug.Log("Fsdf");
            inEnergy.Wire.Power = Power-1;
        }
    }
  
}
