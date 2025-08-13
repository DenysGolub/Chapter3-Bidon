using UnityEngine;

public class InventoryItem
{
    public ItemData itemData;

    public int stackSize;

    public InventoryItem(ItemData itemData)
    {
        this.itemData = itemData;
    }

    public void AddStack()
    {
        stackSize++;
    }

    public void RemoveStack()
    {
        stackSize--;
    }
}
