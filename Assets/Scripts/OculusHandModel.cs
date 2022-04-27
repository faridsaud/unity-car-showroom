using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHandModel : MonoBehaviour
{
    [SerializeField] private InputActionReference triggerAction;
    [SerializeField] private InputActionReference gripAction;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        triggerAction.action.started += OnTriggerPressed;
        triggerAction.action.canceled += OnTriggerUnpressed;
        gripAction.action.started += OnGripPressed;
        gripAction.action.canceled += OnGripUnpressed;
    }

    private void OnTriggerPressed(InputAction.CallbackContext obj)
    {
        anim.SetBool("TriggerPressed", true);
    }

    private void OnTriggerUnpressed(InputAction.CallbackContext obj)
    {
        anim.SetBool("TriggerPressed", false);
    }


    private void OnGripPressed(InputAction.CallbackContext obj)
    {
        anim.SetBool("GripPressed", true);
    }
    
    private void OnGripUnpressed(InputAction.CallbackContext obj)
    {
        anim.SetBool("GripPressed", false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnDestroy()
    {
        triggerAction.action.started -= OnTriggerPressed;
        triggerAction.action.canceled -= OnTriggerUnpressed;
        gripAction.action.started -= OnGripPressed;
        gripAction.action.canceled -= OnGripUnpressed;
    }
}