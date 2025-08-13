using System;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameEventSO gameEvent;
    public GameObject prefab;

    private void OnEnable()
    {
        gameEvent.OnEventRaised += Spawn;
    }

    private void OnDisable()
    {
        gameEvent.OnEventRaised -= Spawn;
    }

    private void Spawn()
    {
        Vector3 vector3 = new Vector3(UnityEngine.Random.Range(-10, 10), 0, 0);
        Instantiate(prefab, vector3, Quaternion.identity);
    }
}
