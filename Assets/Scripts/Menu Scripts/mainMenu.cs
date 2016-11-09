using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class mainMenu : MonoBehaviour
{
	public Canvas startMenu;
    public Canvas quitMenu;
    public Button exploreText;
    public Button comparisonText;
    public Button earthsSeasonText;
    public Button exitText;

	// Use this for initialization
	void Start ()
    {
		startMenu = startMenu.GetComponent<Canvas> ();
        quitMenu = quitMenu.GetComponent<Canvas>();
        exploreText = exploreText.GetComponent<Button>();
        comparisonText = comparisonText.GetComponent<Button>();
        earthsSeasonText = earthsSeasonText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
	}

    public void ExitPress()
    {
		startMenu.enabled = false;
        quitMenu.enabled = true;
        exploreText.enabled = false;
        comparisonText.enabled = false;
        earthsSeasonText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
		startMenu.enabled = true;
        quitMenu.enabled = false;
        exploreText.enabled = true;
        comparisonText.enabled = true;
        earthsSeasonText.enabled = true;
        exitText.enabled = true;
    }

    public void Explore()
    {
        SceneManager.LoadScene("Explore");
    }

    public void SizeComparison()
    {
        SceneManager.LoadScene("SizeComparison");
    }

    public void EarthsSeasons()
    {
        SceneManager.LoadScene("EarthsSeasons");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
