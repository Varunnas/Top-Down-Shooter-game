using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1.0f;
    private float nextFire = 0.0f;


    // Update is called once per frame
    void Update()
    {
        // Check if enough time has passed since the last spawn.
        if (Time.time > nextFire && Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn the dogPrefab and update the next spawn time.
            nextFire = Time.time + fireRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
        }
    }
}


