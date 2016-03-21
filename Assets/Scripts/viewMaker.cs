using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class viewMaker : MonoBehaviour {
    public GameObject mainRaw;
    public GameObject raw1;
    public GameObject raw2;
    public GameObject raw3;
    public GameObject background;
    RawImage mainImg;
    RawImage img1;
    RawImage img2;
    RawImage img3;

	// Use this for initialization
	void Start () {
        float woff = Screen.width * .01f;
        float hoff = Screen.height * .01f;
        print(woff + " " + hoff);
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        background.GetComponent<RawImage>().GetComponent<RectTransform>().sizeDelta = screenSize;
        screenSize.x *= .96f;
        screenSize.y *= .97f;
        mainImg = mainRaw.GetComponent<RawImage>();
        img1 = raw1.GetComponent<RawImage>();
        img2 = raw2.GetComponent<RawImage>();
        img3 = raw3.GetComponent<RawImage>();
        mainRaw.GetComponent<RectTransform>().sizeDelta = screenSize;
        raw1.GetComponent<RectTransform>().sizeDelta = screenSize;
        raw2.GetComponent<RectTransform>().sizeDelta = screenSize;
        raw3.GetComponent<RectTransform>().sizeDelta = screenSize;
        mainRaw.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,-hoff);
        raw1.GetComponent<RectTransform>().anchoredPosition = new Vector2(woff, -hoff);
        raw2.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -hoff);
        raw3.GetComponent<RectTransform>().anchoredPosition = new Vector2(-woff, -hoff);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
