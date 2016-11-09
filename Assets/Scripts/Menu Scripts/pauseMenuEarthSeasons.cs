using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class pauseMenuEarthSeasons : MonoBehaviour
{

    public GameObject pausePanel;
    private bool isPaused;
    private bool isCursorLocked;


    // Use this for initialization
    void Start()
    {
        isPaused = false;
        ToggleCursorState();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            PauseGame(true);
        }
        else
        {
            PauseGame(false);
        }

        if (Input.GetButtonDown("Cancel"))
        {
            SwitchPause();
        }

        CheckForInput();
        CheckIfCursorShouldBeLocked();
    }

    void PauseGame(bool state)
    {
        if (state)
        {
            Time.timeScale = 0.0f; //Paused
        }
        else
        {
            Time.timeScale = 1.0f; //Unpaused
        }
        pausePanel.SetActive(state);
    }

    public void SwitchPause()
    {
        if (isPaused)
        {
            isPaused = false; //Changes the value
        }
        else
        {
            isPaused = true;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void ToggleCursorState()
    {
        isCursorLocked = !isCursorLocked;
    }

    void CheckForInput()
    {
        if (Input.GetKeyDown("escape"))
        {
            ToggleCursorState();
        }
    }

    void CheckIfCursorShouldBeLocked()
    {
        if (isCursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
