using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/Game Event")]
public class GameEventSO : ScriptableObject
{
    public event Action OnEventRaised;

    public void Raise()
    {
        OnEventRaised?.Invoke();
    }
}
