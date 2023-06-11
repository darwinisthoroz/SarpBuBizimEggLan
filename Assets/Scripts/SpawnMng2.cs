using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMng2 : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 30.0f;

    private bool isPrefabSpawned = false;
    private GameObject currentPrefab;
    private float lastSpawnTime;

    private void Start()
    {
        lastSpawnTime = Time.time;
        StartCoroutine(SpawnPrefabs());
    }

    IEnumerator SpawnPrefabs()
    {
        while (true)
        {
            if (!isPrefabSpawned && Time.time - lastSpawnTime >= spawnInterval)
            {
                Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];

                currentPrefab = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
                isPrefabSpawned = true;
                lastSpawnTime = Time.time;
            }

            yield return null;
        }
    }

    private void Update()
    {
        if (isPrefabSpawned && currentPrefab == null)
        {
            isPrefabSpawned = false;
        }
    }
}