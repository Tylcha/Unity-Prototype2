using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //animals array
    public GameObject[] animalPrefebs;

    private float spawnRageX = 20;
    private float spawnPositionZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //start 2 sec later, 1.5 sec spawn
        InvokeRepeating("SpawnRandomlyAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomlyAnimal()
    {
        //randomly 0 to gameobject lenght
        int animalIndex = Random.Range(0, animalPrefebs.Length);
        //randomly spawn animal
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRageX, spawnRageX), 0, spawnPositionZ);

        Instantiate(animalPrefebs[animalIndex], spawnPos, animalPrefebs[animalIndex].transform.rotation);
    }
}
