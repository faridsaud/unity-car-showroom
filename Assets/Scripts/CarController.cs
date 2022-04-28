using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public float speed = 1f;

    public Slider slider;

    private bool _isRunning;
    // Start is called before the first frame update
    void Start()
    {
        if (slider != null)
        {
            speed = slider.value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSpeed(float s)
    {
        speed = s;
    }

    public void UpdateCarSpeed(Slider s)
    {
        SetSpeed(s.value);
    }

    public void StartEngine()
    {
        _isRunning = true;
    }
    
    public void StopEngine()
    {
        _isRunning = true;
    }
}
