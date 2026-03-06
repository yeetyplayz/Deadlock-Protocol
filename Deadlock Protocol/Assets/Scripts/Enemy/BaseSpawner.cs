using UnityEngine;

public abstract class BaseSpawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject prefab;
    public float spawnDelay = 3f;

    protected virtual void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnDelay, spawnDelay);
    }

    protected abstract void Spawn();
}