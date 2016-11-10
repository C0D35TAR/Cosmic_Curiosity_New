using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class earthOrbit : MonoBehaviour
{
    public float orbitSpeed = 10;

    public GameObject earth;
    public GameObject earthText;
    Camera cam;

    GameObject earthCanvas;
    private bool interaction;
    private Text txtRef;

    public bool isInteracting;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        earth = GameObject.Find("Earth");
        earthText = GameObject.Find("EarthText");

        interaction = false;
        earthCanvas = GameObject.Find("EarthCanvas");
        txtRef = GameObject.Find("EarthPopUp").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction == true)
        {
            earthCanvas.SetActive(true);
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 0;
            }
            isInteracting = true;
        }

        if (interaction == false)
        {
            earthCanvas.SetActive(false);
            isInteracting = false;
        }

        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);

        Vector3 vectorToEarth = (earth.transform.position - cam.transform.position);
        //Debug.Log(Vector3.Angle(cam.transform.forward, vectorToEarth));
        float angle = Vector3.Angle(cam.transform.forward, vectorToEarth);

        if (angle <= 90)
        {
            earthText.SetActive(true);
            Vector3 newpos = cam.WorldToScreenPoint(earth.transform.position);
            newpos.y = newpos.y + 40;
            earthText.transform.position = newpos;

        }
        else
        {
            earthText.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT EARTH";
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
