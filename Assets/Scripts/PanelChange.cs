using TMPro;
using UnityEngine;

public class PanelChange : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private GameObject from;
    private GameObject to;
    private GameObject build;
    private GameObject toiletM;
    private GameObject toiletW;
    private GameObject deanery;
    private GameObject coworking;

    bool isPressed;

    private void Start()
    {
        from = panel.transform.GetChild(1).gameObject;
        to = panel.transform.GetChild(2).gameObject;
        build = panel.transform.GetChild(4).gameObject;
        toiletM = panel.transform.GetChild(3).GetChild(0).gameObject;
        toiletW = panel.transform.GetChild(3).GetChild(1).gameObject;
        deanery = panel.transform.GetChild(3).GetChild(2).gameObject;
        coworking = panel.transform.GetChild(3).GetChild(3).gameObject;
    }

    public void ButtonPressed()
    {
        if (isPressed)
        {
            from.GetComponentInChildren<TMP_Text>().text = "Откуда";

            to.GetComponentInChildren<TMP_Text>().text = "Куда";

            build.GetComponentInChildren<TMP_Text>().text = "Построить";

            toiletM.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мужской";

            toiletW.GetComponentInChildren<TMP_Text>().text = "Ж";
            toiletW.transform.GetChild(1).GetComponent<TMP_Text>().text = "Женский";

            deanery.GetComponentInChildren<TMP_Text>().text = "Д";
            deanery.transform.GetChild(1).GetComponent<TMP_Text>().text = "Деканат";

            coworking.GetComponentInChildren<TMP_Text>().text = "К";
            coworking.transform.GetChild(1).GetComponent<TMP_Text>().text = "Коворкинг";
        }
        else
        {
            from.GetComponentInChildren<TMP_Text>().text = "From";

            to.GetComponentInChildren<TMP_Text>().text = "To";

            build.GetComponentInChildren<TMP_Text>().text = "Build";

            toiletM.transform.GetChild(1).GetComponent<TMP_Text>().text = "Men";

            toiletW.GetComponentInChildren<TMP_Text>().text = "W";
            toiletW.transform.GetChild(1).GetComponent<TMP_Text>().text = "Woman";

            deanery.GetComponentInChildren<TMP_Text>().text = "D";
            deanery.transform.GetChild(1).GetComponent<TMP_Text>().text = "Deanary";

            coworking.GetComponentInChildren<TMP_Text>().text = "C";
            coworking.transform.GetChild(1).GetComponent<TMP_Text>().text = "Coworking";
        }

        isPressed = !isPressed;
    }
}
