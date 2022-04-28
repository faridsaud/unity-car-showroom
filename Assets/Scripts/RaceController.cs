using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RaceController : MonoBehaviour
{
    private bool canCarsMove;
    public GameObject[] cars;
    // Start is called before the first frame update
    void Start()
    {
        canCarsMove = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ToggleCarsMovement()
    {
        canCarsMove = !canCarsMove;
        foreach (GameObject car in cars)
        {
            CarController carController = car.GetComponent<CarController>();
            if (canCarsMove)
            {
                carController.StartCar();
            }
            else
            {
                carController.StopCar();
            }
        }
    }
}
