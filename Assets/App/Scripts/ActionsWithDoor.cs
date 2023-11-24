using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionsWithDoor : MonoBehaviour
{
    [SerializeField] private GameObject _actionsMenu;
    [SerializeField] private Slider _openSlider;
    [SerializeField] private Transform _door;
    [SerializeField] private float _offsetY;

    private void Start()
    {
        _door = GetComponent<Transform>();
        _openSlider.minValue = _door.position.y;
        _openSlider.maxValue = _door.position.y + _offsetY;
    }
    public void OpenActionsMenu()
    {
        _actionsMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
    public void CloseActionsMenu()
    {
        _actionsMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void OpenSlider()
    {
        _openSlider.gameObject.SetActive(true);
    }
    public void DoorOpen()
    {
        _door.position = new Vector3(transform.position.x, _openSlider.value, transform.position.z);
    }


}
