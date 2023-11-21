using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue")]
public class Dialogue : ScriptableObject
{
    [SerializeField] private Sprite _icon;
    [SerializeField] private string _name;
    [TextArea]
    [SerializeField] private string _text;

    public string Name { get { return _name; } }
    public Sprite Icon { get { return _icon; } }
    public string Text { get { return _text; } }
}
