using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    public float speed;

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        speed = (float)slider.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setSpeed(float s)
    {
        speed = s;
    }
}
