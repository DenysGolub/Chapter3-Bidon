using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class InventoryManager : MonoBehaviour
{
    public List<InventoryItem> items;
    public static event Action<List<InventoryItem>> OnInventoryChanged;
    public ItemInfoOnClickEventSO onSlotClickedEvent; 

    void Start()
    {
        items = new List<InventoryItem>();
    }


    void OnEnable()
    {
        PickUpItem.onItemPickedUp += AddItemToInventory;

        if (onSlotClickedEvent != null)
        {
            onSlotClickedEvent.RegisterListener(ShowItemData);
        }
    }

    void OnDisable()
    {
        PickUpItem.onItemPickedUp -= AddItemToInventory;
        if (onSlotClickedEvent != null)
        {
            onSlotClickedEvent.UnregisterListener(ShowItemData);            
        }
    }

    private void AddItemToInventory(InventoryItem item)
    {
        var searchItem = items.FirstOrDefault(slot => slot.itemData.name == item.itemData.name);
        if (searchItem == null || !item.itemData.isStackable)
        {
            items.Add(item);
            item.AddStack();
        }
        else
        {
            items[items.IndexOf(searchItem)].AddStack();
        }

        if (OnInventoryChanged != null)
        {
            OnInventoryChanged.Invoke(items);
        }
    }

    private void ShowItemData(ItemData itemData)
    {
        Debug.Log($"{itemData.title} - {itemData.description}");
    }



}
