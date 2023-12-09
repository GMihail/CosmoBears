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
        //number 3 - LvelCompletedMenu
        //number 4 - GameMenu

        [SerializeField] private GameObject[] _windows;
        [SerializeField] private int _activeWindow;
        [SerializeField] private int _previousWindow;
        [SerializeField] private Slider _volumeMusic;
        [SerializeField] private GameObject _embient;
        [SerializeField] private AudioSource _embientSFX;
        public Dropdown _DropDown;

        private void Update()
        {
            if (_windows[4].activeSelf == true)
            {
                _embient.SetActive(true);
                AudioListener.pause = false;
            }
            else if (_windows[2].activeSelf == true)
            {
                AudioListener.pause = true;
            }
            else
            {
                _embient.SetActive(false);
            }
        }
        public void DropDownSettings()
        {
            if (_DropDown.value == 0)
            {
                Screen.SetResolution(1920, 1080, true);
            }
        }
        public void ActivePreviousWindow()
        {
            if (_windows[0].activeSelf == true)
            {
                _activeWindow = 0;
            }
            if (_windows[1].activeSelf == true)
            {
                _activeWindow = 1;
            }
            if (_windows[2].activeSelf == true)
            {
                _activeWindow = 2;
            }
            if (_windows[3].activeSelf == true)
            {
                _activeWindow = 3;
            }
            if (_windows[4].activeSelf == true)
            {
                _activeWindow = 4;
            }
        }
        public void GameMenu()
        {
            _windows[4].SetActive(true);
            _windows[_activeWindow].SetActive(false);
            _previousWindow = _activeWindow;
        }
        public void SettingsButton()
        {
            _windows[1].SetActive(true);
            _windows[_activeWindow].SetActive(false);
            _previousWindow = _activeWindow;
        }
        public void BackButton()
        {
            _windows[_previousWindow].SetActive(true);
            _windows[_activeWindow].SetActive(false);
        }
        public void PauseButton()
        {
            _windows[2].SetActive(true);
            _windows[_activeWindow].SetActive(false);
            _previousWindow = _activeWindow;
        }
        public void MainMenuButton()
        {
            _windows[0].SetActive(true);
            _windows[_activeWindow].SetActive(false);
            _previousWindow = _activeWindow;
        }
        public void LevelCompleted()
        {
            _windows[3].SetActive(true);
            _windows[_activeWindow].SetActive(false);
            _previousWindow = _activeWindow;
        }
        public void SaveGame()
        {

        }
        public void LoadGame()
        {

        }
        public void NextLevel()
        { 
            
        }
    }
}