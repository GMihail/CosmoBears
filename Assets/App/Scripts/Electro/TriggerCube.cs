using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerCube : Triggers.InteractableObject
{
    [SerializeField] private EnergyCube _energyCube;
    [SerializeField] private Battery _battery;

    public void ActiveEnergyCube()
    {
        _energyCube.enabled = true;
        _battery.enabled = false;
    }
    public void ActiveBatteryCube()
    {
        _energyCube.enabled = false;
        _battery.enabled = true;
    }
}
