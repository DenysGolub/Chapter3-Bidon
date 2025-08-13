using System;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public ItemData data;
    public static event Action<InventoryItem> onItemPickedUp;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Player") && onItemPickedUp != null)
        {
            onItemPickedUp.Invoke(new InventoryItem(data));

            Destroy(gameObject);
        }
    }
}
