using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class neptuneOrbit : MonoBehaviour
{
    public float orbitSpeed = 10;

    public GameObject neptune;
    public GameObject neptuneText;
    Camera cam;

    GameObject neptuneCanvas;
    private bool interaction;
    private Text txtRef;

    public bool isInteracting;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        neptune = GameObject.Find("Neptune");
        neptuneText = GameObject.Find("NeptuneText");

        interaction = false;
        neptuneCanvas = GameObject.Find("NeptuneCanvas");
        txtRef = GameObject.Find("NeptunePopUp").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction == true)
        {
            neptuneCanvas.SetActive(true);
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 0;
            }
            isInteracting = true;
        }

        if (interaction == false)
        {
            neptuneCanvas.SetActive(false);
            isInteracting = false;
        }

        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);

        Vector3 vectorToNeptune = (neptune.transform.position - cam.transform.position);
        //Debug.Log(Vector3.Angle(cam.transform.forward, vectorToNeptune));
        float angle = Vector3.Angle(cam.transform.forward, vectorToNeptune);

        if (angle <= 90)
        {
            neptuneText.SetActive(true);
            Vector3 newpos = cam.WorldToScreenPoint(neptune.transform.position);
            newpos.y = newpos.y + 40;
            neptuneText.transform.position = newpos;

        }
        else
        {
            neptuneText.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT NEPTUNE";
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
