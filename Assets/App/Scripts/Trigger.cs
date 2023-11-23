using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private GameObject _actionsWithDoor;
    private void OnTriggerEnter(Collider other)
    {
        _actionsWithDoor.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
    private void OnTriggerExit(Collider other)
    {
        _actionsWithDoor.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
