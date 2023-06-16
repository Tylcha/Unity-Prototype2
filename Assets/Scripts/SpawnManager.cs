using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //animals array
    public GameObject[] animalPrefebs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //randomly 0 to gameobject lenght
        int animalIndex = Random.Range(0, animalPrefebs.Length);

        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPrefebs[animalIndex], new Vector3(0,0,20), animalPrefebs[animalIndex].transform.rotation);
        }
    }
}
