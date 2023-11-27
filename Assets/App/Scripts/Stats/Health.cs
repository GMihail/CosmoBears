using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Health : MonoBehaviour
{
    [SerializeField] private float _energy = 100;
    public void AddHealth(float value)
    {
        if(value <= 0 || _energy <= 0) return;
        _energy -= value;
        FindObjectOfType<PlayerStatistic>().AddHealth(value);
    }

   

}
