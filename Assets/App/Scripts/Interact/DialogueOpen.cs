using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOpen : MonoBehaviour
{
    [SerializeField] private Dialogue _dialogue;
    [SerializeField] private DialogueManager _dialogueManager;
    public void Invoke()
    {
        _dialogueManager.gameObject.SetActive(true);
        _dialogueManager.DialoguePreset = _dialogue;
    }
}
