using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateCar : MonoBehaviour
{
    public Transform carRotatorTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCarRotation(Slider slider)
    {
        carRotatorTransform.rotation = Quaternion.Euler(new Vector3(0f, slider.value, 0f));
    }
}
