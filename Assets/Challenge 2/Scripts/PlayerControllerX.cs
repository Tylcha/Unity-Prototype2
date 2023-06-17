using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogSpawCooldown = 1;
    private float timer = 0;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog, start else timer, 1 second delay
        if (Input.GetKeyDown(KeyCode.Space) && timer >= dogSpawCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
