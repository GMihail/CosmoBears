using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayPlayer : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private float _distance;
    public ActionsWithBomb _bombActionsMenu;
    public ActionsWithDoor _doorActionsMenu;
    private void Update()
    {
        Debug.DrawRay(_camera.transform.position, _camera.transform.forward * _distance, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(_camera.transform.position, _camera.transform.forward * _distance, out hit, _distance))
        {
            Debug.Log("find door");
            if (hit.transform.gameObject.CompareTag("Door"))
            {
                Debug.Log("active window");
                if (Input.GetKeyDown(KeyCode.E)) _doorActionsMenu.OpenActionsMenu();
                if (Input.GetKeyDown(KeyCode.G)) _doorActionsMenu.CloseActionsMenu();
            }
            if (hit.transform.gameObject.CompareTag("Grenade"))
            {
                if (Input.GetKeyDown(KeyCode.E)) _bombActionsMenu.OpenActionsWithBomb();
                if (Input.GetKeyDown(KeyCode.G)) _bombActionsMenu.CloseActionsWithBomb();
            }
        }
        else { Debug.Log(" not found door"); }
    }
}
