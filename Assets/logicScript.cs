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
    public TMP_Text clockText2;
    public TMP_Text clockText3;
    public TMP_Text clockText4;
    public SpriteRenderer greenRender;
    public SpriteRenderer greenRender2;
    public SpriteRenderer greenRender3;
    public SpriteRenderer greenRender4;
    public SpriteRenderer redRender;
    public SpriteRenderer redRender2;
    public SpriteRenderer redRender3;
    public SpriteRenderer redRender4;
    static public int lightColor;
    private float redTime = 17.0f;
    private float yellowTime = 2.0f;
    private float greenTime = 20.0f;
    private float timer = 0.0f;
    private int width, height;
    public float test;
    public float greenClock;
    public float redClock;
    public float yellowClock;
    public bool greenEnabled;
    public bool greenEnabled2;
    public bool greenEnabled3;
    public bool greenEnabled4;
    public bool redEnabled;
    public bool redEnabled2;
    public bool redEnabled3;
    public bool redEnabled4;


    void Awake()
    {
        lightColor = 1; // red light on
        redEnabled = redRender.enabled;
        redEnabled2 = redRender2.enabled;
        redEnabled3 = redRender3.enabled;
        redEnabled4 = redRender4.enabled;
        // changeLight();
        width = Screen.width;
        height = Screen.height;
        // Time.timeScale = scrollBar;
        // Debug.Log(redLight);
    }

    void Update()
    {
        if (lightColor == 0)
        {   greenRender.enabled = true;
            greenRender2.enabled = true;
            greenRender3.enabled = true;
            greenRender4.enabled = true;
            redRender.enabled = false;
            redRender2.enabled = false;
            redRender3.enabled = false;
            redRender4.enabled = false;
            timer += Time.deltaTime;
            test = timer;
            greenClock = greenTime - timer;
            clockText.text = greenClock.ToString("f0");
            clockText2.text = greenClock.ToString("f0");
            clockText3.text = greenClock.ToString("f0");
            clockText4.text = greenClock.ToString("f0");
            if (timer > greenTime)
            {
                timer = timer - greenTime;
                lightColor = 1;           
            }
        }
        else if (lightColor == 1)
        {   
            redRender.enabled = true;
            redRender2.enabled = true;
            redRender3.enabled = true;
            redRender4.enabled = true;
            greenRender.enabled = false;
            greenRender2.enabled = false;
            greenRender3.enabled = false;
            greenRender4.enabled = false;
            timer += Time.deltaTime;
            redClock = redTime - timer;
            clockText.text = "";
            clockText2.text = "";
            clockText3.text = "";
            clockText4.text = "";
            if (timer > redTime)
            {
                timer = timer - redTime;
                lightColor = 2;
            }

        } else if (lightColor == 2)
        {   
            redRender.enabled = true;
            redRender2.enabled = true;
            redRender3.enabled = true;
            redRender4.enabled = true;
            greenRender.enabled = false;
            greenRender2.enabled = false;
            greenRender3.enabled = false;
            greenRender4.enabled = false;
            timer += Time.deltaTime;
            yellowClock = yellowTime - timer;
            clockText.text = "";
            clockText2.text = "";
            clockText3.text = "";
            clockText4.text = "";
            if (timer > yellowTime)
            {
                timer = timer - yellowTime;
                lightColor = 0;
            }

        }
    }
}
