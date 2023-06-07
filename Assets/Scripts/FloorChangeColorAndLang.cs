using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FloorChangeColorAndLang : MonoBehaviour
{
    [SerializeField] private GameObject floorInfo;
    private GameObject number;
    private GameObject floor;
    bool isPressedColor;
    bool isPressedLang;
    // Start is called before the first frame update
    void Start()
    {
        number = floorInfo.transform.GetChild(0).gameObject;
        floor = floorInfo.transform.GetChild(1).gameObject;
    }

    public void ButtonPressedColor()
    {
        if (isPressedColor)
        {
            floorInfo.GetComponent<Image>().color = Color.white;
            number.GetComponentInChildren<TMP_Text>().color = new Color32(157, 157, 157, 255);
            floor.GetComponentInChildren<TMP_Text>().color = new Color32(157, 157, 157, 255);
        }
        else 
        { 
            floorInfo.GetComponent<Image>().color = new Color32(41, 41, 41, 255);
            number.GetComponentInChildren<TMP_Text>().color = new Color32(230, 230, 230, 255);
            floor.GetComponentInChildren<TMP_Text>().color = new Color32(230, 230, 230, 255);
        }
        isPressedColor = !isPressedColor;
    }

    public void ButtonPressedLang()
    {
        if (isPressedLang)
        {
            floor.GetComponentInChildren<TMP_Text>().text = "этаж";
        }
        else
        {
            floor.GetComponentInChildren<TMP_Text>().text = "floor";
        }
        isPressedLang = !isPressedLang;
    }
}