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

    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        if (slider != null)
        {
            speed = slider.value;
        }

        _animator = GetComponent<Animator>();
        StartCoroutine(StartStopCar());
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(StartStopCar());
    }

    public void SetSpeed(float s)
    {
        speed = s;
    }

    public void UpdateCarSpeed(Slider s)
    {
        SetSpeed(s.value);
    }

    public void StartCar()
    {
        _isRunning = true;
    }
    
    public void StopCar()
    {
        _isRunning = false;
    }

    IEnumerator StartStopCar()
    {
        Debug.Log("Start stop car ==> running: " + _isRunning);
        
        _animator.SetBool("isRunning", _isRunning);
        if (_isRunning)
        {
            transform.position -= new Vector3( (speed * Time.deltaTime * 3f), 0f, 0f);
        }
        yield return new WaitForSeconds(0.01f);
    }


}
