using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Puzzle : MonoBehaviour
{
    #region Variables
    private TMP_Text text;
    private string pass = "1488";
    private string _inputstr = string.Empty;

    #endregion

    private void Start()
    {
        text = gameObject.GetComponent<TMP_Text>();
    }
    #region KeypadLogic
    public void EmptyText()
    {
        _inputstr = string.Empty;
        text.text = _inputstr;
    }
    public void Apply()
    {
        if (_inputstr == pass)
        {
           //something happens
        }
    }
    public void Input(string index)
    {
        if (_inputstr.Length < 4)
        {
            _inputstr += index;
            text.text = _inputstr;
        }
    }
    #endregion
}
