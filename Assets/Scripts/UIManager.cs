using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject input1;
    public GameObject input2;
    public GameObject joyStick1;
    public GameObject joyStick2;
    void Update()
    {
        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait or ScreenOrientation.PortraitUpsideDown:
                joyStick1.SetActive(false);
                joyStick2.SetActive(false);
                break;
            case ScreenOrientation.LandscapeLeft or ScreenOrientation.LandscapeRight:
                joyStick1.SetActive(true);
                joyStick2.SetActive(true);
                break;
        }
    }
}
