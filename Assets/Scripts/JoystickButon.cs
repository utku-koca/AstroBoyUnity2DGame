using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickButon : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [HideInInspector]
    public bool tusabasildi;

    public void OnPointerDown(PointerEventData eventData)
    {
        tusabasildi = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        tusabasildi = false;
    }
   
}
