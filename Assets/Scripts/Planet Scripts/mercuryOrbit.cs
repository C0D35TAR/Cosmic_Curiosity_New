using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mercuryOrbit : MonoBehaviour
{
    public float orbitSpeed = 10;

    public GameObject mercury;
    public GameObject mercuryText;
    Camera cam;

    GameObject mercuryCanvas;
    private bool interaction;
    private Text txtRef;

    //Testing
    public bool allowInput;
    public GameObject pauseMenu;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        mercury = GameObject.Find("Mercury");
        mercuryText = GameObject.Find("MercuryText");

        interaction = false;
        mercuryCanvas = GameObject.Find("MercuryCanvas");
        txtRef = GameObject.Find("MercuryPopUp").GetComponent<Text>();

        pauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction == true)
        {
            mercuryCanvas.SetActive(true);
            allowInput = true;
        }

        if (interaction == false)
        {
            mercuryCanvas.SetActive(false);
        }

        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);

        Vector3 vectorToMercury = (mercury.transform.position - cam.transform.position);
        Debug.Log(Vector3.Angle(cam.transform.forward, vectorToMercury));
        float angle = Vector3.Angle(cam.transform.forward, vectorToMercury);

        if (angle <= 90)
        {
            mercuryText.SetActive(true);
            Vector3 newpos = cam.WorldToScreenPoint(mercury.transform.position);
            newpos.y = newpos.y + 40;
            mercuryText.transform.position = newpos;
        }
        else
        {
            mercuryText.SetActive(false);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("CodyIsABigNoob");
            }

            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT MERCURY";
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            interaction = false;
        }
    }
}
