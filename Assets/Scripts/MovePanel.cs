using UnityEngine;

public class MovePanel : MonoBehaviour
{
    bool isPressed;

    void Start()
    {
        
    }

    void Update()
    {
        if (isPressed)
        {
            transform.position = new Vector3(1170, 185, 0);
        }
        else 
        {
            transform.position = new Vector3(1170, -155, 0);
        }

    }

    public void ButtonPressed()
    {
        isPressed = !isPressed;
    }
}