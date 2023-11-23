using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionsWindow : MonoBehaviour
{
    [SerializeField] private GameObject _actionsMenu;
    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E)) Press();
        if(Input.GetKeyDown(KeyCode.G)) Out();
    }
    private void OnTriggerExit(Collider other)
    {
      _actionsMenu.SetActive(false);
    }
    public void Press()
    {
        _actionsMenu.SetActive(true);
    }
    public void Out()
    {
        _actionsMenu.SetActive(false);
    }
    
}
