using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool buttonPressed;
    public static int score;

    public void Update()
    {
        if (buttonPressed && StatusScript.press)
        {
            score++;
        }
        if(buttonPressed && !StatusScript.press)
        {
            score--;
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }
}
