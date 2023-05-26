using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorChose : MonoBehaviour
{
    public GameObject Panel;
    
    public static void LoadFirstFloor()
    {
        SceneManager.LoadScene("1 этаж");
    }
    
    public static void LoadSecondFloor()
    {
        SceneManager.LoadScene("2 этаж");
    }
    
    public static void LoadThirdFloor()
    {
        SceneManager.LoadScene("3 этаж");
    }
    
    public static void LoadFourthFloor()
    {
        SceneManager.LoadScene("4 этаж");
    }

    private void OnTriggerEnter(Collider other)
    {
        Panel.SetActive(true);
    }
}
