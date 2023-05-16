using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    public InputAction pause;

    public GameObject pauseMenu;
    public bool isPaused;

    private void OnEnable() {
        pause.Enable();
    }

    private void OnDisable() {
        pause.Disable();
    }

    void Start()
    {   
        pauseMenu.SetActive(false);  
        pause.performed += _ => SwitchState();
    }

    private void SwitchState() {
        if (isPaused) {
            ResumeGame();
        }
        else {
            PauseGame();
        }
        isPaused = !isPaused;
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);  
    }   

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
