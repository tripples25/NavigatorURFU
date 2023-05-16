using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguage : MonoBehaviour
{
    bool eng;
    public GameObject fromRu;
    public GameObject fromEng;
    public GameObject toRu;
    public GameObject toEng;
    public GameObject buildRu;
    public GameObject buildEng;
    public GameObject deaneryRu;
    public GameObject deaneryEng;
    public GameObject coworkingRu;
    public GameObject coworkingEng;
    // Start is called before the first frame update
    void Start()
    {    
    }

    // Update is called once per frame
    void Update()
    {
        if (eng)
        {
            fromRu.SetActive(false);
            fromEng.SetActive(true);
            toRu.SetActive(false);
            toEng.SetActive(true);
            buildRu.SetActive(false);
            buildEng.SetActive(true);
            deaneryRu.SetActive(false);
            deaneryEng.SetActive(true);
            coworkingRu.SetActive(false);
            coworkingEng.SetActive(true);
        }
        else
        {
            fromRu.SetActive(true);
            fromEng.SetActive(false);
            toRu.SetActive(true);
            toEng.SetActive(false);
            buildRu.SetActive(true);
            buildEng.SetActive(false);
            deaneryRu.SetActive(true);
            deaneryEng.SetActive(false);
            coworkingRu.SetActive(true);
            coworkingEng.SetActive(false);
        }
    }

    public void LanguageStatus()
    {
        eng = !eng;
    }
}
