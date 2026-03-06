using UnityEngine;

public class CircleSpawner : BaseSpawner
{
    [Header("Circle Settings")]
    public Transform player;
    public float spawnRadius = 20f;

    [Header("Building Check")]
    public LayerMask buildingLayer;
    public float checkRadius = 1f;

    protected override void Spawn()
    {
        for (int i = 0; i < 10; i++) // probeert 10 keer een plek
        {
            Vector2 randomCircle = Random.insideUnitCircle.normalized * spawnRadius;

            Vector3 spawnPos = player.position + new Vector3(
                randomCircle.x,
                0,
                randomCircle.y
            );

            if (!Physics.CheckSphere(spawnPos, checkRadius, buildingLayer))
            {
                Instantiate(prefab, spawnPos, Quaternion.identity);
                return;
            }
        }
    }
}