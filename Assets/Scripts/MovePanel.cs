using UnityEngine;

public class MovePanel : MonoBehaviour
{
    bool isPressed;

    void Start()
    {
        
    }
    

    public void ButtonPressed()
    {
        if (isPressed)
        {
            transform.position += new Vector3(0, 360, 0);
        }
        else
        {
            transform.position -= new Vector3(0, 360, 0);
        }
        
        isPressed = !isPressed;
    }
}