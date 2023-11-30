using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Misha
{
    public class ButtonManager : MonoBehaviour
    {
        //number 0 - MainMenu
        //number 1 - SettingsMenu
        //number 2 - PauseMenu

        [SerializeField] private GameObject[] _Windows;
        [SerializeField] private int _ActiveWindow;
        [SerializeField] private int _PreviousWindow;
        public Dropdown _DropDown;


        public void DropDownSettings()
        {
            if (_DropDown.value == 0)
            {
                Screen.SetResolution(1920, 1080, true);
            }
        }
        public void ActivePreviousWindow()
        {
            if (_Windows[0].activeSelf == true)
            {
                _ActiveWindow = 0;
            }
            if (_Windows[1].activeSelf == true)
            {
                _ActiveWindow = 1;
            }
            if (_Windows[2].activeSelf == true)
            {
                _ActiveWindow = 2;
            }
        }
        public void GameMenu()
        {

        }
        public void SettingsButton()
        {
            _Windows[1].SetActive(true);
            _Windows[_ActiveWindow].SetActive(false);
            _PreviousWindow = _ActiveWindow;
        }
        public void BackButton()
        {
            _Windows[_PreviousWindow].SetActive(true);
            _Windows[_ActiveWindow].SetActive(false);
        }
        public void PauseButton()
        {
            _Windows[2].SetActive(true);
            _Windows[_ActiveWindow].SetActive(false);
            _PreviousWindow = _ActiveWindow;
        }
        public void MainMenuButton()
        {
            _Windows[0].SetActive(true);
            _Windows[_ActiveWindow].SetActive(false);
            _PreviousWindow = _ActiveWindow;
        }
        public void SaveGame()
        {

        }
        public void LoadGame()
        {

        }


    }
}