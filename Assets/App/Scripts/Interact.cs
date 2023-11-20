using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class Interact: MonoBehaviour
{
    [SerializeField] private Transform _rayCastPosition;
    private InteractableObject tempObj;
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 5;
        Gizmos.DrawRay(_rayCastPosition.position, direction);
    }

    private void Update()
    {
        Ray ray = new Ray(_rayCastPosition.position, transform.forward);
        
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            

            if (hit.collider.gameObject.TryGetComponent(out InteractableObject @object)){
                @object.Animation.SetBool("show",true);
                @object.Animation.SetBool("hide", false);
                tempObj = @object;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    @object.EventBtn.Invoke();
                }
            }
            else
            {
                Debug.Log(tempObj);
                tempObj.Animation.SetBool("show", false);
                tempObj.Animation.SetBool("hide",true);
            }
        }
    }
}
