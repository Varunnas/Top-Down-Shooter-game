using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontalInput;
    private float verticalInput;
    private float speed=20.0f;
    private float xBound=25.0f;
    public GameObject food;
    public Transform projectileSpawnPoint;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.z >= -5.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -5.5f);
        }
        else if (transform.position.z <= -13.0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -13.0f);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);




        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(food,   projectileSpawnPoint.position, food.transform.rotation);
        }

    }
}
