using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyCarMovementSouth : MonoBehaviour
{
public Rigidbody toyCarRigidBody;

    public float speed = 15f;


    // Start is called before the first frame update
    void Start()
    {
        // toyCarRigidBody.AddForce(0,0,-1 * 10f);

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        toyCarRigidBody.AddForce(1, 0, 0 * speed);
    //     if (logicScript.lightColor == 0)
    //     { //light is green
    //         toyCarRigidBody.AddForce(1, 1, 0 * speed);
    //     }
    //     else if (logicScript.lightColor == 1)
    //     { // light is red
    //         // Debug.Log(logicScript.lightColor);
    //         if (transform.position.z > -4)
    //         {
    //             toyCarRigidBody.AddForce(1, 1, 0 * speed);
    //         }
    //         else if (transform.position.z < -4)
    //         {
    //             toyCarRigidBody.AddForce(1, 1, 0 * 0f);
    //         }

    //     }

        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}
