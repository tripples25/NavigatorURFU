using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMovem : MonoBehaviour
{
    bool isPressed;
    Animator panelAnimator;

    void Start()
    {
        panelAnimator = GetComponent<Animator>();
    }

    public void ButtonPressed()
    {
        if (isPressed)
        {
            panelAnimator.SetTrigger("Open");
        }
        else
        {
            panelAnimator.SetTrigger("Close");
        }

        isPressed = !isPressed;
    }
}
