using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawnScript : MonoBehaviour
{
    // public GameObject car3Spawn;
    public GameObject[] cars;
    public logicScript logicScriptRef;
    // public GameObject trafficLight;


    public float spawnRate = 2;
    private float timer = 0;
    public int indexOfCars;

    public bool redLightOn;

    void Awake () {
        logicScriptRef = GameObject.Find("trafficLight").GetComponent<logicScript>();
    }


    // Start is called before the first frame update
    void Start()
    {
        // spawner();
        Debug.Log(logicScriptRef.redLight);
        Debug.Log(cars.Length);
    }
    void FixedUpdate() {
        // Debug.Log(logicScriptRef.redLight);
        if (!logicScriptRef.redLight) {
            // Debug.Log("True!!");
        } else if (logicScriptRef.redLight) {
            if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        } else 
        {
                spawner();
            timer = 0;
        }
        }
    }
    void spawner() {
        indexOfCars = Random.Range(0, cars.Length-1);
        // Debug.Log(indexOfCars);
        Debug.Log(cars.Length);
            // Instantiate(car3Spawn, transform.position, transform.rotation);
            if (cars.Length > 0) {
                Instantiate(cars[0], new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            } else {
                Debug.Log(cars.Length);
            }
        
        // if ()
    }
}
