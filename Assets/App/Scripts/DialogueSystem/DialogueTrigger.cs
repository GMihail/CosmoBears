using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueSystems
{
    public DialogueSystem dialogueSystem;
    public string nameDialogueForStart;
}

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] private DialogueManager _manager;
    [SerializeField] private DialogueSystems[] _dialogueSystems;
    [SerializeField] private string _dialogueNameForPlay;
    public DialogueManager Manager
    {
        get { return _manager; }
    }

    public void PlayDialogue(string name)
    {
        foreach (DialogueSystems item in _dialogueSystems)
        {
           if(item.nameDialogueForStart == name)
           {
                StartCoroutine(item.dialogueSystem.ShowDialogue());
           }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayDialogue(_dialogueNameForPlay);
        }
    }

}
