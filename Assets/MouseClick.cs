using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    // Start is called before the first frame update
    public float mouseSensitivity = 100.0f;
    public float clampAngle = 80.0f;

    private float rotY = 0.0f; // rotation around the up/y axis
    private float rotX = 0.0f; // rotation around the right/x axis

void Start()
{
    Vector3 rot = transform.localRotation.eulerAngles;
    rotY = rot.y;
    rotX = rot.x;
}

void Update()
{
    float mouseX = Input.GetAxis("Mouse X");
    float mouseY = -Input.GetAxis("Mouse Y");

    rotY += mouseX * mouseSensitivity * Time.deltaTime;
    rotX += mouseY * mouseSensitivity * Time.deltaTime;

    rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

    Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
    transform.rotation = localRotation;

   if (Input.GetMouseButtonDown(0)) // check if the left mouse button is clicked
{
    RaycastHit hit;
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    if (Physics.Raycast(ray, out hit))
    {
        if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Clickable"))
        {
            // the player clicked on a clickable object, do something here
            Debug.Log("Clicked on " + hit.collider.gameObject.name);
        }
    }
}
}
}