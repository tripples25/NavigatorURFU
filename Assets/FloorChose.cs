using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorChose : MonoBehaviour
{
    public GameObject Panel;
    [SerializeField] private TMP_InputField inputField;
    
    public static void LoadFloor(char floor)
    {
        SceneManager.LoadScene(floor + " этаж");
    }

    private void OnTriggerEnter(Collider other)
    {
        LoadFloor(inputField.text[0]);
    }
}
