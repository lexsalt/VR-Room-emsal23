using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UIElements;
//
using NUnit.Framework.Internal;
using UnityEngine.UI;
using UnityEditor.ShaderGraph;

//

public class toyCarMovement : MonoBehaviour
{
    public Rigidbody toyCarRigidBody;

    public float speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        // toyCarRigidBody.AddForce(0,0,-1 * 10f);

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (logicScript.lightColor == 1)
        { //light is green
            // toyCarRigidBody.AddForce(0, 0, 1 * speed);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (logicScript.lightColor == 0)
        { // light is red
            // Debug.Log(logicScript.lightColor);
            if (transform.position.z > -4)
            {
                // toyCarRigidBody.AddForce(0, 0, 1 * speed);
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            else if (transform.position.z < -4)
            {
                toyCarRigidBody.AddForce(0, 0, 1 * 0f);
            }

        }

        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}
