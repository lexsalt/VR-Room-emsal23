using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawnScript : MonoBehaviour
{
    // public GameObject car3Spawn;
    public GameObject[] cars;

    public float spawnRate = 2;
    private float timer = 0;
    public int indexOfCars;

    // Start is called before the first frame update
    void Start()
    {
        spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        } else 
        {
            spawner();
            timer = 0;
        }
        
    }
    void spawner() {
        indexOfCars = Random.Range(0, 3);
            // Instantiate(car3Spawn, transform.position, transform.rotation);
        Instantiate(cars[indexOfCars], new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        // if ()
    }
}
