using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Triggers
{
    public class UltimateInteractableObject : MonoBehaviour
    {
        public enum Triggers
        {
            None,
            press_F,
            left_mouse,
            right_mouse,
            collision_with_object
        }

        public enum TargetsList //список целей для 
        {
            None,
            RedButton,
            In,
            Out
        }

        public Triggers triggers;
        public TargetsList target;

        public UnityEvent called_event;

        private void Update()
        {
            CheckKeyBoardMouseTriggers();
        }

        private void CheckKeyBoardMouseTriggers() //триггеры нажатия 
        {
            if (called_event != null)
            {
                switch (triggers)
                {
                    case Triggers.press_F:
                        if (Input.GetKeyDown(KeyCode.F))
                            called_event.Invoke();
                        break;
                    case Triggers.left_mouse:
                        if (Input.GetMouseButtonDown(0))
                            called_event.Invoke();
                        break;
                    case Triggers.right_mouse:
                        if (Input.GetMouseButtonDown(1))
                            called_event.Invoke();
                        break;
                }
            }
        }
        private void OnTriggerEnter(Collider collision) //триггер касания
        {
            if (called_event != null)
            {
                if (triggers == Triggers.collision_with_object)
                {
                    if (collision.gameObject.CompareTag(target.ToString()))
                    {
                        called_event.Invoke();
                    }
                }
            }
        }
    }
}

