using UnityEngine;
using System.Collections;

public class camMouseLook : MonoBehaviour 
{
	Vector2 mouselook;
	Vector2 smoothv;  

    public float mouseSensitivity = 100.0f;
    public float clampAngle = 80.0f;

    private float rotY = 0.0f; // rotation around the up/y axis
    private float rotX = 0.0f; // rotation around the right/x axis

    public float speed = 10.0f;

	// Use this for initialization
	void Start () 
	{
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }
	
	// Update is called once per frame
	void FixedUpdate () 
	{
        float ForwardBack = Input.GetAxis("Vertical") * speed;
        float LeftRight = Input.GetAxis("Horizontal") * speed;
        float UpDown = Input.GetAxis("UpDown") * speed;
        ForwardBack *= Time.deltaTime;
        LeftRight *= Time.deltaTime;
        UpDown *= Time.deltaTime;

        transform.Translate(LeftRight, UpDown, ForwardBack);


        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX += mouseY * mouseSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;

    }
}
