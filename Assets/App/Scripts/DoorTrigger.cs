using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _actionsWithDoor;
    [SerializeField] private Slider _openSlider;
    [SerializeField] private Transform _door;
    [SerializeField] private float _offsetY;
    private void Start()
    {
        _door = GetComponentInChildren<Transform>();
        _openSlider.minValue = _door.position.y;
        _openSlider.maxValue = _door.position.y + _offsetY;
    }
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
    public void OpenButton()
    { 
        _openSlider.gameObject.SetActive(true);
    }
    public void DoorOpen()
    {
        _door.position = new Vector3(transform.position.x, _openSlider.value, transform.position.z);
    }

}
