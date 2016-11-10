using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class jupiterOrbit : MonoBehaviour
{
    public float orbitSpeed = 10;

    public GameObject jupiter;
    public GameObject jupiterText;
    Camera cam;

    GameObject jupiterCanvas;
    private bool interaction;
    private Text txtRef;

    public bool isInteracting;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        jupiter = GameObject.Find("Jupiter");
        jupiterText = GameObject.Find("JupiterText");

        interaction = false;
        jupiterCanvas = GameObject.Find("JupiterCanvas");
        txtRef = GameObject.Find("JupiterPopUp").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction == true)
        {
            jupiterCanvas.SetActive(true);
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 0;
            }
            isInteracting = true;
        }

        if (interaction == false)
        {
            jupiterCanvas.SetActive(false);
            isInteracting = false;
        }

        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);

        Vector3 vectorToJupiter = (jupiter.transform.position - cam.transform.position);
        //Debug.Log(Vector3.Angle(cam.transform.forward, vectorToJupiter));
        float angle = Vector3.Angle(cam.transform.forward, vectorToJupiter);

        if (angle <= 90)
        {
            jupiterText.SetActive(true);
            Vector3 newpos = cam.WorldToScreenPoint(jupiter.transform.position);
            newpos.y = newpos.y + 40;
            jupiterText.transform.position = newpos;

        }
        else
        {
            jupiterText.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT JUPITER";
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
