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

    public SpriteRenderer greenRender;
    public SpriteRenderer redRender;
    private float redTime = 17.0f;
    private float yellowTime = 2.0f;
    private float greenTime = 30.0f;
    
    public float speed = 15f;

    private float timer = 0.0f;
    private float visualTime = 0.0f;
    private int width, height;
    private float value = 10.0f;
    // private float scrollBar = 1.0f;

    public bool Light = true;
    public float test;
    public float greenClock;
    public float redClock;
    public bool greenEnabled;
    public bool redEnabled;



    // Start is called before the first frame update
    void Start()
    {
        // toyCarRigidBody.AddForce(0,0,-1 * 10f);
        Debug.Log(Light);
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // lightStatus = script.light;
        if (!Light)
        {
            timer += Time.deltaTime;
            test = timer;
            greenClock = greenTime - timer;
            if (timer > greenTime)
            {
                timer = timer - greenTime;
                Light = true;           
                // Time.timeScale = scrollBar;
            }
        }
        else if (Light)
        {   
            timer += Time.deltaTime;
            redClock = redTime - timer;
            if (timer > redTime)
            {
                timer = timer - redTime;
                Light = false;
                // Time.timeScale = scrollBar;
            }

        }

        toyCarRigidBody.AddForce(0,0, 1 * speed);
            if (Light)
            {
                speed = 0f;            
            } else if (!Light) {
                speed = 15f;
            }
        if (transform.position.y < -5) 
        {
            Destroy(gameObject);
        }
    }
}
