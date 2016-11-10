using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class marsOrbit : MonoBehaviour
{
    public float orbitSpeed = 10;

    public GameObject mars;
    public GameObject marsText;
    Camera cam;

    GameObject marsCanvas;
    private bool interaction;
    private Text txtRef;

    public bool isInteracting;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        mars = GameObject.Find("Mars");
        marsText = GameObject.Find("MarsText");

        interaction = false;
        marsCanvas = GameObject.Find("MarsCanvas");
        txtRef = GameObject.Find("MarsPopUp").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction == true)
        {
            marsCanvas.SetActive(true);
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 0;
            }
            isInteracting = true;
        }

        if (interaction == false)
        {
            marsCanvas.SetActive(false);
        }

        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);

        Vector3 vectorToMars = (mars.transform.position - cam.transform.position);
        //Debug.Log(Vector3.Angle(cam.transform.forward, vectorToMars));
        float angle = Vector3.Angle(cam.transform.forward, vectorToMars);

        if (angle <= 90)
        {
            marsText.SetActive(true);
            Vector3 newpos = cam.WorldToScreenPoint(mars.transform.position);
            newpos.y = newpos.y + 40;
            marsText.transform.position = newpos;

        }
        else
        {
            marsText.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT MARS";
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
