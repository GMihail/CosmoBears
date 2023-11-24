using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActionWithBomb : MonoBehaviour
{
    [SerializeField] private GameObject _timerButton;
    [SerializeField] private GameObject _10secButton;
    [SerializeField] private GameObject _30secButton;
    [SerializeField] private GameObject _60secButton;
    [SerializeField] private GameObject _actionsWithBomb;
    [SerializeField] private Text _timerText;

    public void TimerButton()
    {
        _10secButton.SetActive(true);
        _30secButton.SetActive(true);
        _60secButton.SetActive(true);
        _timerText.gameObject.SetActive(true);
    }
    public void Plus10secButton()
    {
        var _timerInt = int.Parse(_timerText.text);
        var summ = _timerInt + 10;
        _timerText.text = summ.ToString();
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E)) OpenActionsWithBomb();
        if (Input.GetKeyDown(KeyCode.G)) CloseActionsWuthBomb();
    }
    public void OpenActionsWithBomb()
    {
        _actionsWithBomb.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
    public void CloseActionsWuthBomb()
    {
        //_10secButton.SetActive(false);
        //_30secButton.SetActive(false);
        //_60secButton.SetActive(false);
        _actionsWithBomb.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
