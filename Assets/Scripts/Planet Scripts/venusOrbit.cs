using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class venusOrbit : MonoBehaviour
{
    public float orbitSpeed = 10;

    public GameObject venus;
    public GameObject venusText;
    Camera cam;

    GameObject venusCanvas;
    private bool interaction;
    private Text txtRef;

    public bool isInteracting;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        venus = GameObject.Find("Venus");
        venusText = GameObject.Find("VenusText");

        interaction = false;
        venusCanvas = GameObject.Find("VenusCanvas");
        txtRef = GameObject.Find("VenusPopUp").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction == true)
        {
            venusCanvas.SetActive(true);
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 0;
            }
            isInteracting = true;
        }

        if (interaction == false)
        {
            venusCanvas.SetActive(false);
            isInteracting = false;
        }

        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);

        Vector3 vectorToVenus = (venus.transform.position - cam.transform.position);
        //Debug.Log(Vector3.Angle(cam.transform.forward, vectorToVenus));
        float angle = Vector3.Angle(cam.transform.forward, vectorToVenus);

        if (angle <= 90)
        {
            venusText.SetActive(true);
            Vector3 newpos = cam.WorldToScreenPoint(venus.transform.position);
            newpos.y = newpos.y + 40;
            venusText.transform.position = newpos;

        }
        else
        {
            venusText.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT VENUS";
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
