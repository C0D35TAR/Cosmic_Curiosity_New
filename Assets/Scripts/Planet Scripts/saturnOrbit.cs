using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class saturnOrbit : MonoBehaviour
{
    public float orbitSpeed = 10;

    public GameObject saturn;
    public GameObject saturnText;
    Camera cam;

    GameObject saturnCanvas;
    private bool interaction;
    private Text txtRef;

    public bool isInteracting;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        saturn = GameObject.Find("Saturn");
        saturnText = GameObject.Find("SaturnText");

        interaction = false;
        saturnCanvas = GameObject.Find("SaturnCanvas");
        txtRef = GameObject.Find("SaturnPopUp").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction == true)
        {
            saturnCanvas.SetActive(true);
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 0;
            }
            isInteracting = true;
        }

        if (interaction == false)
        {
            saturnCanvas.SetActive(false);
            isInteracting = false;
        }

        transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);

        Vector3 vectorToSaturn = (saturn.transform.position - cam.transform.position);
        //Debug.Log(Vector3.Angle(cam.transform.forward, vectorToSaturn));
        float angle = Vector3.Angle(cam.transform.forward, vectorToSaturn);

        if (angle <= 90)
        {
            saturnText.SetActive(true);
            Vector3 newpos = cam.WorldToScreenPoint(saturn.transform.position);
            newpos.y = newpos.y + 40;
            saturnText.transform.position = newpos;

        }
        else
        {
            saturnText.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            interaction = true;
            txtRef.text = "PRESS 'R' TO LEARN MORE ABOUT SATURN";
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
