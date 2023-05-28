using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public GameObject joy1;
    public GameObject joy2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Screen.orientation == ScreenOrientation.LandscapeLeft ||
            Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            joy1.SetActive(true);
            joy2.SetActive(true);
        }
        else
        {
            joy1.SetActive(false);
            joy2.SetActive(false);
        }
    }
}
