using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SlotInfo : MonoBehaviour
{
    [SerializeField] private ItemInfoOnClickEventSO showInfoAction;

    ItemData data;

    public void Init(ItemData _data)
    {

        this.data = _data;
        Debug.Log(_data);
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
        btn.image.sprite = data.icon;
    }

    public void OnClick()
    {
        if (showInfoAction != null)
        {
            showInfoAction.Raise(data);            
        }
    }
}
