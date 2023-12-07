using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Dialogues
{
    public Dialogue Dialogue;
    public float TimeForShow;
    public UnityEvent _eventEnd;
}

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] private Dialogues[] _dialogues;
    [SerializeField] private DialogueTrigger _trigger;

    private void Start()
    {
        _trigger = FindAnyObjectByType<DialogueTrigger>();
    }

    public IEnumerator ShowDialogue()
    {
        _trigger.Manager.gameObject.SetActive(true);
        foreach (Dialogues item in _dialogues)
        {
            _trigger.Manager.DialoguePreset = item.Dialogue;
            yield return new WaitForSeconds(item.TimeForShow);
            if (item._eventEnd.GetPersistentEventCount() > 0)
            {
                item._eventEnd.Invoke();
            }
        }
        _trigger.Manager.gameObject.SetActive(false);
        
    }

}
