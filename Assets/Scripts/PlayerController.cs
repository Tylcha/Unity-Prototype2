using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    //movement speed
    public float speed = 10;

    //game area in x range
    private float xRange = 10;

    //Bullet Gameobject
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //move the player right left
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        //keep the player inbounds (game area)
        //if -10: stay.x = -10, current.y, current.z
        if (transform.position.x < -xRange)
        {
            
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //if +10: stay.x = 10, current.y, current.z
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Lauch projectile from player

        }
    }
}
