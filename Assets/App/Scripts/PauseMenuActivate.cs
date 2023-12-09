using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using Unity.VisualScripting;
using Misha;

public class PauseMenuActivate : MonoBehaviour
{
    [SerializeField] private ButtonManager _pause;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { _pause.PauseButton();}
    }
}   
