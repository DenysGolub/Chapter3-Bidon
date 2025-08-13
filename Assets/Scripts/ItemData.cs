using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "ScriptableObjects/InventoryItem")]
public class ItemData : ScriptableObject
{
    public string title;
    public string description;
    public Sprite icon;
    public bool isStackable;
    public GameObject itemPrefab;
   
}
