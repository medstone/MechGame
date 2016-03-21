using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour
{
    public GameObject horiz;
    public GameObject vert;
    public float vLimit;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (Cursor.lockState == CursorLockMode.None)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        horiz.transform.Rotate(new Vector3(0, h, 0));
        if (vert.transform.rotation.eulerAngles.x + v > vLimit && vert.transform.rotation.eulerAngles.x < 90)
        {
            v = vLimit - vert.transform.rotation.eulerAngles.x;
        }
        else if ((vert.transform.rotation.eulerAngles.x + v < 0 || vert.transform.rotation.eulerAngles.x + v > 360 - vLimit) && 360 - Mathf.Abs(vert.transform.rotation.x + v) < 360 - vLimit)
        {
            v = -vert.transform.rotation.eulerAngles.x + (360 - vLimit);
        }
        else if (vert.transform.rotation.eulerAngles.x + v < 360 - vLimit && vert.transform.rotation.eulerAngles.x + v > vLimit)
        {
            v = 0;
        }
        vert.transform.Rotate(new Vector3(v, 0, 0));
    }
}

