using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _pauseMenuBackground;

    private PlayerControls _playerControls;

    private void Start()
    {
        _playerControls = new PlayerControls();
        _playerControls.Settings.OpenPauseMenu.Enable();
        _playerControls.Settings.OpenPauseMenu.performed += OpenPauseMenu;
        _playerControls.Settings.OpenPauseMenu.canceled += ClosePauseMenu;
    }
    private void OpenPauseMenu(InputAction.CallbackContext context)
    {
        _pauseMenuBackground.SetActive(true);
        Time.timeScale = 0;
    }
    private void ClosePauseMenu(InputAction.CallbackContext context)
    {
        ResumeButton();
    }
    public void ResumeButton()
    {
        _pauseMenuBackground.SetActive(false);
        Time.timeScale = 1;
    }
    public void SettingsButton()
    {

    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
