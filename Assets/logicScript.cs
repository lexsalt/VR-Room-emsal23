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
    private float visualTime = 0.0f;
    private int width, height;
    private float value = 10.0f;
    // private float scrollBar = 1.0f;

    public bool redLight = true;
    public float test;
    public float greenClock;
    public float redClock;
    public bool greenEnabled;
    public bool redEnabled;


    void Awake()
    {
        // changeLight();
        width = Screen.width;
        height = Screen.height;
        // Time.timeScale = scrollBar;
    }

    void Update()
    {
        if (!redLight)
        {
            greenRender.enabled = true;
            redRender.enabled = false;
            timer += Time.deltaTime;
            test = timer;
            greenClock = greenTime - timer;
            clockText.text = greenClock.ToString("f0");
            if (timer > greenTime)
            {
                timer = timer - greenTime;
                redLight = true;           
                // Time.timeScale = scrollBar;
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
                // Time.timeScale = scrollBar;
            }

        }

    }
    /*
    void OnGUI()
    {
        // GUIStyle sliderDetails = new GUIStyle(GUI.skin.GetStyle("horizontalSlider"));
        // GUIStyle sliderThumbDetails = new GUIStyle(GUI.skin.GetStyle("horizontalSliderThumb"));
        GUIStyle labelDetails = new GUIStyle(GUI.skin.GetStyle("label"));

        // Set the size of the fonts and the width/height of the slider.
        labelDetails.fontSize = 6 * (width / 200);
        // sliderDetails.fixedHeight = height / 32;
        // sliderDetails.fontSize = 12 * (width / 200);
        // sliderThumbDetails.fixedHeight = height / 32;
        // sliderThumbDetails.fixedWidth = width / 32;

        // Show the slider. Make the scale to be ten times bigger than the needed size.
        // value = GUI.HorizontalSlider(new Rect(width / 8, height / 4, width - (4 * width / 8), height - (2 * height / 4)),
            // value, 5.0f, 20.0f, sliderDetails, sliderThumbDetails);

        // Show the value from the slider. Make sure that 0.5, 0.6... 1.9, 2.0 are shown.
        float v = ((float)Mathf.RoundToInt(value)) / 10.0f;
        GUI.Label(new Rect(width / 8, height / 3.25f, width - (2 * width / 8), height - (2 * height / 4)),
            "timeScale: " + redTime.ToString("f1"), labelDetails);
            // "timeScale: " + v.ToString("f1"), labelDetails);
        // scrollBar = v;

        // Display the recorded time in a certain size.
        labelDetails.fontSize = 14 * (width / 200);
        GUI.Label(new Rect(width / 8, height / 2, width - (2 * width / 8), height - (2 * height / 4)),
            "Timer value is: " + test.ToString("f0") + " seconds.", labelDetails);
            // "Timer value is: " + visualTime.ToString("f4") + " seconds.", labelDetails);
    }
    */
}
