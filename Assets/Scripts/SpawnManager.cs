using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] LootBox;
    public float spawnInterval = 15f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomLootBox", spawnInterval, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomLootBox()
    {
        int randomIndex = Random.Range(0, LootBox.Length);
        Vector3 randomPosition = GenerateRandomPosition();

        Instantiate(LootBox[randomIndex], randomPosition, Quaternion.identity);
    }

    Vector3 GenerateRandomPosition()
    {
        float randomX = Random.Range(-7.03f, 7.03f);
        float randomY = Random.Range(-0.32f, 5.22f);
        float zPosition = -3.51f;

        return new Vector3(randomX, randomY, zPosition);
    }


}
