using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SpawnFromAddressables : MonoBehaviour
{
    public string prefabAddress = "Autumn";
    List<GameObject> swords;

    void Start()
    {
        swords = new List<GameObject>();   
    }

    public void Load()
    {
        var position = swords.Count * 0.5f * Vector3.up;
        Addressables.InstantiateAsync(prefabAddress, position, Quaternion.identity).Completed += handle =>
        {
            swords.Add(handle.Result);
        };
    }

    public void DeleteLast()
    {
        if (swords.Count <= 0)
        {
            return;
        }
        GameObject lastSword = swords.Last();
        Addressables.ReleaseInstance(lastSword);
        swords.Remove(lastSword);

    }

    public void DeleteAll()
    {
        foreach (var sword in swords)
        {
            Addressables.ReleaseInstance(sword);
        }

        swords.Clear();
    }
}
