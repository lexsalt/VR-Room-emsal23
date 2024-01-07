using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenLightScript : MonoBehaviour
{
  private new Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = Color.gray;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(logicScript.lightColor);
                if (logicScript.lightColor == 0) {
            renderer.material.color = Color.gray;
        } else if (logicScript.lightColor == 1) {
            renderer.material.color = Color.green;
        } else if (logicScript.lightColor == 2) {
            renderer.material.color = Color.gray;
        }
    }
}
