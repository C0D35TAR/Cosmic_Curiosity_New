using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class plutoOrbit : MonoBehaviour
{
    public float orbitSpeed = 10;

    public GameObject pluto;
    public GameObject plutoText;
    Camera cam;

    GameObject plutoCanvas;
    private bool interaction;
    private Text txtRef;

    public bool isInteracting;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        pluto = GameObject.Find("Pluto");
        plutoText = GameObject.Find("PlutoText");

        interaction = false;
        plutoCanvas = GameObject.Find("PlutoCanvas");
        txtRef = GameObject.Find("PlutoPopUp").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction == true)
        {
            plutoCanvas.SetActive(true);
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 0;
            }
            isInteracting = true;
        }

        if (interaction == false)
        {
            plutoCanvas.SetActive(false);
            isInteracting = false;
        }

        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);

        Vector3 vectorToPluto = (pluto.transform.position - cam.transform.position);
        //Debug.Log(Vector3.Angle(cam.transform.forward, vectorToPluto));
        float angle = Vector3.Angle(cam.transform.forward, vectorToPluto);

        if (angle <= 90)
        {
            plutoText.SetActive(true);
            Vector3 newpos = cam.WorldToScreenPoint(pluto.transform.position);
            newpos.y = newpos.y + 40;
            plutoText.transform.position = newpos;

        }
        else
        {
            plutoText.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT PLUTO";
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
