using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/New ItemInfoOnClick")]
public class ItemInfoOnClickEventSO : ScriptableObject
{
    private Action<ItemData> listeners;

    public void Raise(ItemData value)
    {
        listeners?.Invoke(value);
    }

    public void RegisterListener(Action<ItemData> listener)
    {
        listeners += listener;
    }

    public void UnregisterListener(Action<ItemData> listener)
    {
        listeners -= listener;
    }
}
