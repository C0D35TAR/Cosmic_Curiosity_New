using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class pauseMenuExplore : MonoBehaviour
{
    //public GameObject pausePanel;
    //private bool isPaused;
    private bool isCursorLocked;

    public Canvas pauseMenu;
    public Button mainMenu;
    public Button sunText;
    public Button mercuryText;
    public Button venusText;
    public Button earthText;
    public Button marsText;
    public Button jupiterText;
    public Button saturnText;
    public Button uranusText;
    public Button neptuneText;
    public Button plutoText;

    // Use this for initialization
    void Start()
    {
        // Time.timeScale = 1.0f;
        //isPaused = false;
        ToggleCursorState();

        pauseMenu = pauseMenu.GetComponent<Canvas>();
        mainMenu = mainMenu.GetComponent<Button>();
        sunText = sunText.GetComponent<Button>();
        mercuryText = mercuryText.GetComponent<Button>();
        venusText = venusText.GetComponent<Button>();
        earthText = earthText.GetComponent<Button>();
        marsText = marsText.GetComponent<Button>();
        jupiterText = jupiterText.GetComponent<Button>();
        saturnText = saturnText.GetComponent<Button>();
        uranusText = uranusText.GetComponent<Button>();
        neptuneText = neptuneText.GetComponent<Button>();
        plutoText = plutoText.GetComponent<Button>();

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused; 
        }

        if (isPaused)
        {
            //PauseGame(true);
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            //PauseGame(false);
            pausePanel.SetActive(false);
            Time.timeScale = 1.0f;
        }
        */

        /*
        if (Input.GetButtonDown("Cancel"))
        {
            SwitchPause();
        }
        */

        CheckForInput();
        CheckIfCursorShouldBeLocked();
    }

    /*
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
    */

    /*
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
    */

    public void MainMenu() //Loads the MainMenu Scene
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