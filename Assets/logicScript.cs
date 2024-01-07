using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.ShaderGraph;

// Time.deltaTime example.
//
// Wait two seconds and display waited time.
// This is typically just beyond 2 seconds.
// Allow the speed of the time to be increased or decreased.
// It can range between 0.5 and 2.0. These changes only
// happen when the timer restarts.

public class logicScript : MonoBehaviour
{
    public TMP_Text clockText;
    public SpriteRenderer greenRender;
    public SpriteRenderer redRender;
    private float redTime = 17.0f;
    private float yellowTime = 2.0f;
    private float greenTime = 30.0f;
    private float timer = 0.0f;
    private int width, height;
    public bool redLight = true;
    public float test;
    public float greenClock;
    public float redClock;
    public bool greenEnabled;
    public bool redEnabled;


    void Awake()
    {
        redEnabled = redRender.enabled;
        // changeLight();
        width = Screen.width;
        height = Screen.height;
        // Time.timeScale = scrollBar;
        // Debug.Log(redLight);
    }

    void Update()
    {
        if (!redLight)
        {   greenRender.enabled = true;
            redRender.enabled = false;
            timer += Time.deltaTime;
            test = timer;
            greenClock = greenTime - timer;
            clockText.text = greenClock.ToString("f0");
            if (timer > greenTime)
            {
                timer = timer - greenTime;
                redLight = true;           
            }
        }
        else if (redLight)
        {   
            redRender.enabled = true;
            greenRender.enabled = false;
            timer += Time.deltaTime;
            redClock = redTime - timer;
            clockText.text = "";
            if (timer > redTime)
            {
                timer = timer - redTime;
                redLight = false;
            }

        }
    }
}
