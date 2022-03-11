using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IDropHandler
{

    public int id;

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("item dropped");


        if(eventData.pointerDrag != null)
        {
           if(eventData.pointerDrag.GetComponent<PhotoPuzzle>().id == id)
            {
                //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<PhotoPuzzle>().setCorrect(true);
            }
            else
            {
                eventData.pointerDrag.GetComponent<PhotoPuzzle>().setCorrect(false);
                //eventData.pointerDrag.GetComponent<PhotoPuzzle>().Reset();
            }

            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;


        }
       
    }

    
}
