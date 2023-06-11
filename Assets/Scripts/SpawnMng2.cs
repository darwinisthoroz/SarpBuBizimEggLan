using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMng2 : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 30f; 

    private void Start()
    {
        StartCoroutine(SpawnPrefabs());
    }

    IEnumerator SpawnPrefabs()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];

            Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}