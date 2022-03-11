using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PhotoPuzzle : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    //enter mouse
    public void OnBeginDrag(PointerEventData eventData)
    {
      
        group.blocksRaycasts = false;
    }

    //dragging
    public void OnDrag(PointerEventData eventData)
    {
        
        rect.anchoredPosition += eventData.delta;

    }

    //release mouse click

    public void OnEndDrag(PointerEventData eventData)
    {
        
        group.blocksRaycasts = true;
    }

    //mouseclick
    public void OnPointerDown(PointerEventData eventData)
    {
        
    }




    private RectTransform rect;
    private CanvasGroup group;
    public int id;
    private Vector2 pos;
    public bool correct = false;


    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        group = GetComponent<CanvasGroup>();
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reset()
    {
        transform.position = pos;
    }


    public void setCorrect(bool cor)
    {
        correct = cor;
        Debug.Log(correct);
    }


}
