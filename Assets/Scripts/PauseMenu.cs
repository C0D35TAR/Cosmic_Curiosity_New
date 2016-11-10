using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour
{

    private bool isPaused;
    public bool isPlanetPaused;
    public GameObject pausePanel;

    public mercuryOrbit mercuryscript;
    public venusOrbit venusscript;
    public earthOrbit earthscript;
    public marsOrbit marsscript;
    public jupiterOrbit jupiterscript;
    public saturnOrbit saturnscript;
    public uranusOrbit uranusscript;
    public neptuneOrbit neptunescript;
    public plutoOrbit plutoscript;

    // Use this for initialization
    void Start()
    {
        mercuryscript = GameObject.Find("Mercury").GetComponent<mercuryOrbit>();
        venusscript = GameObject.Find("Venus").GetComponent<venusOrbit>();
        earthscript = GameObject.Find("Earth").GetComponent<earthOrbit>();
        marsscript = GameObject.Find("Mars").GetComponent<marsOrbit>();
        jupiterscript = GameObject.Find("Jupiter").GetComponent<jupiterOrbit>();
        saturnscript = GameObject.Find("Saturn").GetComponent<saturnOrbit>();
        uranusscript = GameObject.Find("Uranus").GetComponent<uranusOrbit>();
        neptunescript = GameObject.Find("Neptune").GetComponent<neptuneOrbit>();
        plutoscript = GameObject.Find("Pluto").GetComponent<plutoOrbit>();

        Time.timeScale = 1.0f;
        isPaused = false;

        isPlanetPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!mercuryscript.isInteracting && !venusscript.isInteracting && !earthscript.isInteracting && !marsscript.isInteracting && !jupiterscript.isInteracting && !saturnscript.isInteracting && !uranusscript.isInteracting && !neptunescript.isInteracting && !plutoscript.isInteracting)
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

}
