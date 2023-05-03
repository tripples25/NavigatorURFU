using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FloatingPanelController : MonoBehaviour
{
    public Transform player;
    private TextMeshPro textMeshPro;

    private void Awake()
    {
        player = Camera.main.transform;
        textMeshPro = GetComponent<TextMeshPro>();
    }

    private void Start()
    {
        textMeshPro.text = transform.name;
        textMeshPro.renderer.enabled = false;
    }

    private void Update()
    {
        transform.rotation = player.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        textMeshPro.renderer.enabled = true;
    }
    
    private void OnTriggerExit(Collider other)
    {
        textMeshPro.renderer.enabled = false;
    }
}
