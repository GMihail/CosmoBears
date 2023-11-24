using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wire : Energy
{
    [SerializeField] private bool _isPower = false;
    [SerializeField] private bool _sharePower;
    [Header("Debug")]
    [SerializeField] private TMP_Text _debugtext;
    public bool IsPower
    {
        get { return _isPower; }
        set { _isPower = value; }
    }

    private void Update()
    {
        if(Power > 0)
        {
            _isPower = true;
        }
        else
        {
            _isPower = false;
        }
        _debugtext.text = $"isPower:{_isPower}\nenrgy:{Power}";
    }
  
}
