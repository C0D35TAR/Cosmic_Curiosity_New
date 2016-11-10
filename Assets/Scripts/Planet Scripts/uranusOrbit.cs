using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class uranusOrbit : MonoBehaviour
{
    public float orbitSpeed = 10;

    public GameObject uranus;
    public GameObject uranusText;
    Camera cam;

    GameObject uranusCanvas;
    private bool interaction;
    private Text txtRef;

    public bool isInteracting;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        uranus = GameObject.Find("Uranus");
        uranusText = GameObject.Find("UranusText");

        interaction = false;
        uranusCanvas = GameObject.Find("UranusCanvas");
        txtRef = GameObject.Find("UranusPopUp").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction == true)
        {
            uranusCanvas.SetActive(true);
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 0;
            }
            isInteracting = true;
        }

        if (interaction == false)
        {
            uranusCanvas.SetActive(false);
            isInteracting = false;
        }


        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);

        Vector3 vectorToUranus = (uranus.transform.position - cam.transform.position);
        //Debug.Log(Vector3.Angle(cam.transform.forward, vectorToUranus));
        float angle = Vector3.Angle(cam.transform.forward, vectorToUranus);

        if (angle <= 90)
        {
            uranusText.SetActive(true);
            Vector3 newpos = cam.WorldToScreenPoint(uranus.transform.position);
            newpos.y = newpos.y + 40;
            uranusText.transform.position = newpos;

        }
        else
        {
            uranusText.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT URANUS";
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
