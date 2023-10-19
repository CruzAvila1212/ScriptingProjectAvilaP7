using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Component<Renderer>().material.color = Color.red
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Component<Renderer>().material.color = Color.green
        }
    }
}
