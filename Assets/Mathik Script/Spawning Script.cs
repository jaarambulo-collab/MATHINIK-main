using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningScript : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    public int minObjectsToSpawn = 1;
    public int maxObjectsToSpawn = 5;
    public Vector3 spawnAreaMin = new Vector3(-10, 1, 5);
    public Vector3 spawnAreaMax = new Vector3(10, 5, 10);

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        int numberOfObjects = Random.Range(minObjectsToSpawn, maxObjectsToSpawn + 1);

        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(
                Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                Random.Range(spawnAreaMin.y, spawnAreaMax.y),
                Random.Range(spawnAreaMin.z, spawnAreaMax.z)
            );

            GameObject objectToSpawn = objectPrefabs[Random.Range(0, objectPrefabs.Length)];

            Instantiate(objectToSpawn, randomSpawnPosition, Quaternion.identity);
        }
    }
}
