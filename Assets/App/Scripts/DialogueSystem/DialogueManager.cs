using Cinemachine;
using GoSystem;
using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Dialogue _dialoguePreset;
    [SerializeField] private float _timeBtwChars;
    [SerializeField] private float _timeBtwWords;
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

  
}
