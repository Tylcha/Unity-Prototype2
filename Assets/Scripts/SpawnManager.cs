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
        InvokeRepeating("SpawnAgressiveAnimal", startDelay, spawnInterval);
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
    void SpawnAgressiveAnimal()
    {
        float xPositive = 25;
        float xNegative = -25;
        
        float zMaxRange = 16;
        float zMinRange = 6;
        float zRandomRange = Random.Range(zMaxRange,zMinRange);

        float yPositiveDegress = 90;
        float yegativeDegress = -90;

        //randomly 0 to gameobject lenght
        int animalIndex = Random.Range(0, animalPrefebs.Length);
        
        //static x position
        float[] xRandom = { -25, 25 };

        //<--------------------------------------------------------------------->

        //RandomZ area, x-25
        Vector3 SpawnPosAgrressiveXPositive = new Vector3(xNegative, 0, zRandomRange);
        
        //90 degress
        Instantiate(animalPrefebs[animalIndex], SpawnPosAgrressiveXPositive, Quaternion.Euler(0,yPositiveDegress,0));

        //<---------------------------------------------------------------------->

        //RandomZ area, x-25
        Vector3 SpawnPosAgrressiveXNegative = new Vector3(xPositive, 0, zRandomRange);

        //-90 deggress
        Instantiate(animalPrefebs[animalIndex], SpawnPosAgrressiveXNegative, Quaternion.Euler(0, yegativeDegress, 0));
    }
}
