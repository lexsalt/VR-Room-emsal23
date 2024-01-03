using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
    public Rigidbody car_rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        car_rigidBody.AddForce(-transform.forward * 10f);
    }

    // Update is called once per frame
    void Update()
    {
        car_rigidBody.AddForce(-transform.forward * 2f);
    }
}
