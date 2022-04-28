using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class RaceController : MonoBehaviour
{
    private bool _canCarsMove;
    public GameObject[] cars;

    private bool _shouldRandomizeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _canCarsMove = false;
        _shouldRandomizeSpeed = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ToggleCarsMovement()
    {
        _canCarsMove = !_canCarsMove;
        foreach (GameObject car in cars)
        {
            CarController carController = car.GetComponent<CarController>();
            if (_canCarsMove)
            {
                carController.StartCar(_shouldRandomizeSpeed);
            }
            else
            {
                carController.StopCar();
            }
        }
    }

    public void OnToggleRandomSpeeds(Toggle toggle)
    {
        _shouldRandomizeSpeed = toggle.isOn;
    }
}
