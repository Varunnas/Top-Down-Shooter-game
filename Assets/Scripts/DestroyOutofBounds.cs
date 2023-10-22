using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 32.0f;
    private float lowerBound = -15.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > 25 ||  transform.position.x < -25) 
        {
           Destroy(gameObject) ;
        }
    }
}
