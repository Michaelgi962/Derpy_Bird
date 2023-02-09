using System.Collections;
using UnityEngine;

public class cloudSpawner : MonoBehaviour
{
    public GameObject cloudPrefab;
    public float spawnRate = 8f;
    public float spawnRadius = 10f;
    private float nextSpawnTime = 0f;
    private float spawnPosY;

    private void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnCloud();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    private void SpawnCloud()
    {
        spawnPosY = Random.Range(0f, 1f) * spawnRadius;
        Instantiate(cloudPrefab, new Vector3(transform.position.x, spawnPosY,0), transform.rotation);
    }
}