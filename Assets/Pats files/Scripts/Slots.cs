using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IDropHandler
{

    public int id;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("item dropped");


        if(eventData.pointerDrag != null)
        {
           if(eventData.pointerDrag.GetComponent<PhotoPuzzle>().id == id)
            {
                Debug.Log("correct");
            }
            else
            {
                Debug.Log("wrong");
            }



            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }
       
    }

    
}
