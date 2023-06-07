using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorChange : MonoBehaviour
{
    [SerializeField] private GameObject floor;
    private GameObject number;
    // Start is called before the first frame update
    void Start()
    {
        number = floor.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var activeSceneName = SceneManager.GetActiveScene().name;
        if (activeSceneName == "1 этаж")
        {
            number.GetComponentInChildren<TMP_Text>().text = "1";
        }
        else if (activeSceneName == "2 этаж")
        {
            number.GetComponentInChildren<TMP_Text>().text = "2";
        }
        else if (activeSceneName == "3 этаж")
        {
            number.GetComponentInChildren<TMP_Text>().text = "3";
        }
        else
        {
            number.GetComponentInChildren<TMP_Text>().text = "4";
        }
    }
}
