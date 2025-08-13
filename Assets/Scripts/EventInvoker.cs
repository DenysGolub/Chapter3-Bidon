using UnityEngine;

public class EventInvoker : MonoBehaviour
{
    public GameEventSO gameEvent;

    public void TriggerEvent()
    {
        gameEvent.Raise();
    }
}
