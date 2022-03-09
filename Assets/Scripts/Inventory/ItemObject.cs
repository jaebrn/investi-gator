using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    //Attach this script to a prefab for it to be collectible & able to be put in inventory
    public InventoryItemData referenceItem; // ref to scriptable object

    void OnMouseOver()
    {
        Debug.Log("Mouse hovering");
        if (Input.GetMouseButtonDown(0)) // if this is clicked 
        {
            OnHandlePickupItem();
        }
    }

    public void OnHandlePickupItem() // adds item to inventory, removes in-game instance
    {
        InventorySystem.current.Add(referenceItem);
        Destroy(gameObject);
    }
}
