using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;    
    public int numberOfObjects = 10;       
    public float spawnInterval = 1.0f;    
    public float spawnRange = 4f;          
    void Start()
    {
       
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
           
            int randomIndex = Random.Range(0, objectsToSpawn.Length);

          
            GameObject objectToSpawn = objectsToSpawn[randomIndex];
            GameObject n = Instantiate(objectToSpawn, GetRandomPosition(), Quaternion.identity)as GameObject;

           
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    Vector3 GetRandomPosition()
    {
       
        float randomX = Random.Range(-spawnRange, spawnRange);
        float randomY = Random.Range(-spawnRange, spawnRange);
        return new Vector3(randomX, randomY, 0f);
    }

    void Update()
    {
    }
 
    
}

