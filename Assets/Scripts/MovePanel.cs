using System.Collections;
using UnityEngine;

public class MovePanel : MonoBehaviour
{
    bool isPressed;
    private Vector3 standardPos;
    private Vector3 pressedPos;

    void Start()
    {
        standardPos = this.transform.position;
        pressedPos = standardPos -= new Vector3(0, 560, 0);
    }
    

    public void ButtonPressed()
    {
        if (isPressed)
        {
            StopAllCoroutines();
            StartCoroutine(MoveUp());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(MoveDown());
        }
        
        isPressed = !isPressed;
    }

    public IEnumerator MoveDown()
    {
        var firstPos = transform.position;
        var newPos = transform.position - new Vector3(0, 560, 0);
        while (transform.position != newPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPos, 8);
            yield return new WaitForSeconds(0.005f);
        }
    }
    
    public IEnumerator MoveUp()
    {
        var firstPos = transform.position;
        var newPos = transform.position + new Vector3(0, 560, 0);
        while (transform.position != newPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPos,  8);
            yield return new WaitForSeconds(0.005f);
        }
    }
}