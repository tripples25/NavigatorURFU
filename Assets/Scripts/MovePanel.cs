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
        pressedPos = standardPos -= new Vector3(0, Screen.width / 2 - 10, 0);
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
        var newPos = transform.position - new Vector3(0, Screen.width / 2 + 40, 0);
        //570
        while (Vector3.Distance(transform.position, newPos) >= 0.008f)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPos, 12);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
    
    public IEnumerator MoveUp()
    {
        var firstPos = transform.position;
        var newPos = transform.position + new Vector3(0, Screen.width / 2 + 40, 0);
        while (Vector3.Distance(transform.position, newPos) >= 0.008f)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPos,  12);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}