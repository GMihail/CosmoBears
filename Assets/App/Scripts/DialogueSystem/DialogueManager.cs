using GoSystem;
using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Dialogue _dialoguePreset;
    public Dialogue DialoguePreset
    {
        private get
        {
            return _dialoguePreset;
        }
        set
        {
            _dialoguePreset = value;
        }
    }
    private void Update()
    {
        if(DialoguePreset != null)
        {
            _image.sprite = _dialoguePreset.Icon;
            _name.text = _dialoguePreset.Name;
            _text.text = _dialoguePreset.Text;
        }
    }
    private void OnEnable()
    {
        FindObjectOfType<ThirdPersonController>().enabled = false;
        FindObjectOfType<GoCameraSystem>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    private void OnDisable()
    {
        FindObjectOfType<ThirdPersonController>().enabled = true;
        FindObjectOfType<GoCameraSystem>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
