using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnergyCube : Energy
{
    [SerializeField] private TMP_Text _debugText;
    private OutEnergy _outEnergy;
    private InEnergy _inEnergy;
    private void Update()
    {
        _debugText.text = $"{Power}";
    }

    public void SetPower()
    {
        Power = _outEnergy.Wire.Power - 1;
    }
    public void SharePower()
    {
        _inEnergy.Wire.Power = Power - 1;
    }
}
