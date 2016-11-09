using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour
{

    private bool isPaused;
    public bool isPlanetPaused;
    public GameObject pausePanel;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1.0f;
        isPaused = false;

        isPlanetPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }

}
