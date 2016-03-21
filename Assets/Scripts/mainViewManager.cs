using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mainViewManager : MonoBehaviour {
    public RenderTexture firstPerson;
    public RenderTexture thirdPerson;
    public RenderTexture information;
    public GameObject firstPersonCamera;
    public GameObject thirdPersonCamera;
    cameraMovement firstCam;
    cameraMovement thirdCam;
    public enum mainStatus {  first = 0, third, info };
    public mainStatus stat;
    RawImage mainImg;

	// Use this for initialization
	void Start() {
        mainImg = gameObject.GetComponent<RawImage>();
        firstCam = firstPersonCamera.GetComponent<cameraMovement>();
        thirdCam = thirdPersonCamera.GetComponent<cameraMovement>();
        mainImg.texture = firstPerson;
        stat = mainStatus.first;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            mainImg.texture = firstPerson;
            if(stat == mainStatus.third)
            {
                thirdCam.enabled = false;
            }
            firstCam.enabled = true;
            stat = mainStatus.first;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            mainImg.texture = information;
            if(stat == mainStatus.third)
            {
                thirdCam.enabled = false;
            }
            else if(stat == mainStatus.first)
            {
                firstCam.enabled = false;
            }
            stat = mainStatus.info;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            mainImg.texture = thirdPerson;
            if(stat == mainStatus.first)
            {
                firstCam.enabled = false;
            }
            thirdCam.enabled = true;
            stat = mainStatus.third;
        }
    }
}
