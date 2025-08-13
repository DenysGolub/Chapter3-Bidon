using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public GameEventSO gameEvent;
    public Renderer targetRenderer;

    private void OnEnable()
    {
        gameEvent.OnEventRaised += ChangeColor;
    }

    private void OnDisable()
    {
        gameEvent.OnEventRaised -= ChangeColor;
    }

    private void ChangeColor()
    {
        targetRenderer.material.color = Random.ColorHSV();
    }
}
