using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelColor : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Sprite langL;
    [SerializeField] private Sprite langB;
    [SerializeField] private Sprite thL;
    [SerializeField] private Sprite thB;

    private GameObject from;
    private GameObject to;
    private GameObject toiletM;
    private GameObject toiletW;
    private GameObject deanery;
    private GameObject coworking;
    private GameObject language;
    private GameObject theme;

    private bool isPressed;

    private void Start()
    {
        from = panel.transform.GetChild(1).gameObject;
        to = panel.transform.GetChild(2).gameObject;
        toiletM = panel.transform.GetChild(3).GetChild(0).gameObject;
        toiletW = panel.transform.GetChild(3).GetChild(1).gameObject;
        deanery = panel.transform.GetChild(3).GetChild(2).gameObject;
        coworking = panel.transform.GetChild(3).GetChild(3).gameObject;
        language = panel.transform.GetChild(5).gameObject;
        theme = panel.transform.GetChild(6).gameObject;
    }

    public void ButtonPressed()
    {
        var elements = new GameObject[] { from, to, toiletM, toiletW, deanery, coworking };

        if (isPressed)
        {
            panel.GetComponent<Image>().color = Color.white;

            /*
            foreach (GameObject e in elements)
            {
                e.GetComponent<UnityEngine.UI.Image>().color = new Color32(230, 230, 230, 255);
                if (e.GetComponentInChildren<TMP_Text>() != null)
                {
                    e.GetComponentInChildren<TMP_Text>().color = new Color32(157, 157, 157, 255);
                }
                if (e.transform.GetChild(1).GetComponent<TMP_Text>() != null)
                {
                    e.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color32(157, 157, 157, 255);
                }
            }
            */
            from.GetComponent<Image>().color = new Color32(230, 230, 230, 255);
            from.GetComponentInChildren<TMP_Text>().color = new Color32(157, 157, 157, 255);

            to.GetComponent<Image>().color = new Color32(230, 230, 230, 255);
            to.GetComponentInChildren<TMP_Text>().color = new Color32(157, 157, 157, 255);

            toiletM.GetComponent<Image>().color = new Color32(230, 230, 230, 255);
            toiletM.GetComponentInChildren<TMP_Text>().color = new Color32(157, 157, 157, 255);
            toiletM.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color32(157, 157, 157, 255);

            toiletW.GetComponent<Image>().color = new Color32(230, 230, 230, 255);
            toiletW.GetComponentInChildren<TMP_Text>().color = new Color32(157, 157, 157, 255);
            toiletW.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color32(157, 157, 157, 255);

            deanery.GetComponent<Image>().color = new Color32(230, 230, 230, 255);
            deanery.GetComponentInChildren<TMP_Text>().color = new Color32(157, 157, 157, 255);
            deanery.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color32(157, 157, 157, 255);

            coworking.GetComponent<Image>().color = new Color32(230, 230, 230, 255);
            coworking.GetComponentInChildren<TMP_Text>().color = new Color32(157, 157, 157, 255);
            coworking.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color32(157, 157, 157, 255);

            language.GetComponent<Image>().sprite = langL;
            theme.GetComponent<Image>().sprite = thL;
        }
        else
        {
            panel.GetComponent<Image>().color = new Color32(41, 41, 41, 255);

            /*
            foreach (GameObject e in elements)
            {
                e.GetComponent<UnityEngine.UI.Image>().color = new Color32(56, 58, 60, 255);

                if (e.GetComponentInChildren<TMP_Text>() != null)
                {
                    e.GetComponentInChildren<TMP_Text>().color = Color.white;
                }

                if (e.transform.GetChild(1).GetComponent<TMP_Text>() != null)
                {
                    e.transform.GetChild(1).GetComponent<TMP_Text>().color = Color.white;
                }
            }
            */
            from.GetComponent<Image>().color = new Color32(56, 58, 60, 255);
            from.GetComponentInChildren<TMP_Text>().color = new Color32(230, 230, 230, 255);

            to.GetComponent<Image>().color = new Color32(56, 58, 60, 255);
            to.GetComponentInChildren<TMP_Text>().color = new Color32(230, 230, 230, 255);

            toiletM.GetComponent<Image>().color = new Color32(56, 58, 60, 255);
            toiletM.GetComponentInChildren<TMP_Text>().color = new Color32(230, 230, 230, 255);
            toiletM.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color32(230, 230, 230, 255);

            toiletW.GetComponent<Image>().color = new Color32(56, 58, 60, 255);
            toiletW.GetComponentInChildren<TMP_Text>().color = new Color32(230, 230, 230, 255);
            toiletW.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color32(230, 230, 230, 255);

            deanery.GetComponent<Image>().color = new Color32(56, 58, 60, 255);
            deanery.GetComponentInChildren<TMP_Text>().color = new Color32(230, 230, 230, 255);
            deanery.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color32(230, 230, 230, 255);

            coworking.GetComponent<Image>().color = new Color32(56, 58, 60, 255);
            coworking.GetComponentInChildren<TMP_Text>().color = new Color32(230, 230, 230, 255);
            coworking.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color32(230, 230, 230, 255);

            language.GetComponent<Image>().sprite = langB;
            theme.GetComponent<Image>().sprite = thB;
        }

        isPressed = !isPressed;
    }
}
