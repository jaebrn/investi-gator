using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventorySystem : MonoBehaviour
{
    public static InventorySystem current;
    private Dictionary<InventoryItemData, InventoryItem> itemDictionary;
    public List<InventoryItem> inventory;

    private void Awake() //dictionary setup
    {

        current = this;
        inventory = new List<InventoryItem>();
        itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();

        DontDestroyOnLoad(gameObject);
    }

    public InventoryItem Get(InventoryItemData referenceData) // dictionary setup cont'd
    {
        if(itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            return value;
        }
        return null;
    }

    public void Add(InventoryItemData referenceData) // item add
    {
        if(itemDictionary.TryGetValue(referenceData, out InventoryItem value)) // if exists, add
        {
            value.AddToStack();
        }
        else // if doesnt exist, create, then add
        {
            InventoryItem newItem = new InventoryItem(referenceData);
            inventory.Add(newItem);
            itemDictionary.Add(referenceData, newItem);
        }
    }

    public void Remove(InventoryItemData referenceData) // item removal
    {
        if(itemDictionary.TryGetValue(referenceData, out InventoryItem value)) // reduces stack size
        {
            value.RemoveFromStack();

            if(value.stackSize == 0) // removes item if stack size == 0
            {
                inventory.Remove(value);
                itemDictionary.Remove(referenceData);
            }
        }
    }

    public event Action onInventoryChangedEvent; // TBA!!
    public void InventoryChangedEvent()
    {
        if(onInventoryChangedEvent!= null)
        {
            onInventoryChangedEvent();
        }
    }
}
