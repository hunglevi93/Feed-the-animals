using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPos1 = new Vector3(-spawnRangeX, 0, Random.Range(5, spawnPosZ));
        Vector3 spawnPos2 = new Vector3(spawnRangeX, 0, Random.Range(5, spawnPosZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int animalIndex1 = Random.Range(0, animalPrefabs.Length);
        int animalIndex2 = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex1], spawnPos1, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0, -90, 0));
        Instantiate(animalPrefabs[animalIndex2], spawnPos2, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0, 90, 0));
    } 
}
