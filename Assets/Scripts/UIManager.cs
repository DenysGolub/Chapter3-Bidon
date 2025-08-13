using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject slotPrefab;
    public ItemInfoOnClickEventSO onSlotClickedEvent; 
    void OnEnable()
    {
        InventoryManager.OnInventoryChanged += RefreshUI;
    }

    void OnDisable()
    {
        InventoryManager.OnInventoryChanged -= RefreshUI;
    }

    private void RefreshUI(List<InventoryItem> list)
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);            
        }

        for (int i = 0; i < list.Count; i++)
        {
            GameObject slotGO = Instantiate(slotPrefab, this.transform);
            SlotInfo slotInfo = slotGO.GetComponent<SlotInfo>();
            slotGO.GetComponentInChildren<TextMeshProUGUI>().text = list[i].stackSize.ToString();
            slotInfo.Init(list[i].itemData);
            
        }
    }
}