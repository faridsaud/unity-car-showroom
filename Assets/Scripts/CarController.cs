using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CarController : MonoBehaviour
{
    public float speed;

    private bool _isRunning;
    private bool _shouldRandomizeSpeed;

    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
        StartCoroutine(StartStopCar());
    }

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

    public void StartCar(bool shouldRandomizeSpeed)
    {
        Debug.Log("Starting Car ==> Randomize Speeds: " + _shouldRandomizeSpeed);
        _isRunning = true;
        _shouldRandomizeSpeed = shouldRandomizeSpeed;
    }
    
    public void StopCar()
    {
        _isRunning = false;
    }

    IEnumerator StartStopCar()
    {
        _animator.SetBool("isRunning", _isRunning);
        if (_isRunning)
        {
            float s = GetSpeed();
            Debug.Log("Speed " + s);
            transform.position -= new Vector3( (s * Time.deltaTime * 3f), 0f, 0f);
        }
        yield return new WaitForSeconds(0.01f);
    }

    private float GetSpeed()
    {
        if (_shouldRandomizeSpeed)
        {
            return Random.Range(0, 1);
        }

        return speed;
    }


}
