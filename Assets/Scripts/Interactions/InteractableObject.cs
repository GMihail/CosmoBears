using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Triggers
{
    public class InteractableObject : MonoBehaviour
    {
        private UltimateInteractableObject _interactableObject;
        public List<UnityEvent> objectActions;
        public int indexOfAction;
        private void Awake()
        {
            _interactableObject = GetComponent<UltimateInteractableObject>();
            SetEvent();
        }

        public void SetEvent()
        {
            _interactableObject.called_event.AddListener(() => objectActions[indexOfAction].Invoke());
        }
    }
}

