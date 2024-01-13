using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeSpawnScript : MonoBehaviour
{
    public GameObject Vespa;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        } else 
        {
            spawner();
            timer = 0;
            randomSpawnRate();
        }
        
    }
    void spawner() {
        Instantiate(Vespa, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }
    void randomSpawnRate () {
        spawnRate = Random.Range(7,11);
    }
}
