using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayPlayer : MonoBehaviour
{
    [SerializeField] private float _distance;
    public ActionsWithBomb _bombActionsMenu;
    public ActionsWithDoor _doorActionsMenu;
    public Transform _startRayCast;

    private void Update()
    {
        Debug.DrawRay(_startRayCast.transform.position, _startRayCast.transform.forward * _distance, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(_startRayCast.transform.position, _startRayCast.transform.forward * _distance, out hit, _distance))
        {
            if (hit.transform.gameObject.CompareTag("Door"))
            {
                if (Input.GetKeyDown(KeyCode.E)) _doorActionsMenu.OpenActionsMenu();
            }
            if (hit.transform.gameObject.CompareTag("Grenade"))
            {
                if (Input.GetKeyDown(KeyCode.E)) _bombActionsMenu.OpenActionsWithBomb();
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape)) _bombActionsMenu.CloseActionsWithBomb();
        if (Input.GetKeyDown(KeyCode.Escape)) _doorActionsMenu.CloseActionsMenu();
    }
}
