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
        toyCarRigidBody.AddForce(0,0, 1 * speed);
        if (transform.position.y < -5) 
        {
            Destroy(gameObject);
        }
    }
}
