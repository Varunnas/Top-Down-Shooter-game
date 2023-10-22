using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMAnager : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 1.5f   , 1.5f);
        InvokeRepeating("SpawnRightSideAnimal", 2, 2.5f);
        InvokeRepeating("SpawnLeftSideAnimal", 2, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnRandomAnimal()
    {
        int animalElement = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalElement], new Vector3(Random.Range(-23,23), 0, Random.Range(20,30)), animalPrefabs[animalElement].transform.rotation);
    }

    void SpawnRightSideAnimal()
    {
        int animalElement = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalElement], new Vector3(24, 0, Random.Range(-5, 0)), Quaternion.Euler(0, -90, 0));
    }

    void SpawnLeftSideAnimal()
    {
        int animalElement = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalElement], new Vector3(-24, 0, Random.Range(-5, 0)), Quaternion.Euler(0, 90, 0));
    }

}