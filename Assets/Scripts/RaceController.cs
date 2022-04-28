using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RaceController : MonoBehaviour
{
    private bool gameStarted;
    public GameObject[] cars;
    // Start is called before the first frame update
    void Start()
    {
        gameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            return;
        }
        foreach (GameObject car in cars)
        {
            Transform carTransform = car.GetComponent<Transform>();
            CarController carController = car.GetComponent<CarController>();
            
            carTransform.position -= new Vector3( (carController.speed * Time.deltaTime * 3f), 0f, 0f);
        }
    }

    public void OnGameStart()
    {
        Debug.Log("Starting!");
        gameStarted = !gameStarted;
    }
}
