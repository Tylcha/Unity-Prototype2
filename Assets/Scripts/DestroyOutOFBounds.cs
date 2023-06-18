using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOFBounds : MonoBehaviour
{
    //z ggame area field variable
    private float topBound = 30;

    //z game area field variable for animals
    private float downAnimals = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //delete gameobject if pass the field(game area)
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > 26 || transform.position.x < -26)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < downAnimals)
        {
            FindObjectOfType<ScoreManager>().IncreaseHealt();
            Destroy(gameObject);
        }
    }
}
