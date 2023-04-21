using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool IsButtonPressed {get; private set;}
    void IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        IsButtonPressed = true;
    }

    void IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
    {
        IsButtonPressed = false;
    }



}
