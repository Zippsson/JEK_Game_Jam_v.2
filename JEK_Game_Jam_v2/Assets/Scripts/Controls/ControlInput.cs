using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlInput : MonoBehaviour
{
    protected DefaultControls controls; 
    public Vector3 movement;
    public float inputMagnitude;

    protected void Awake()
    {
        controls = new DefaultControls();

        controls.CharControl.LeftStick.performed += context => Move(context);
        controls.CharControl.LeftStick.canceled += context => Stop(context);

        controls.CharControl.Start.performed += context => PressStart();
        controls.CharControl.Start.canceled += context => ReleaseStart();

        controls.CharControl.Select.performed += context => PressSelect();
        controls.CharControl.Select.canceled += context => ReleaseSelect();

        controls.CharControl.ButtonA.performed += context => PressA();
        controls.CharControl.ButtonA.canceled += context => ReleaseA();

        controls.CharControl.ButtonB.performed += context => PressB();
        controls.CharControl.ButtonB.canceled += context => ReleaseB();

        controls.CharControl.ButtonX.performed += context => PressX();
        controls.CharControl.ButtonX.canceled += context => ReleaseX();

        controls.CharControl.ButtonY.performed += context => PressY();
        controls.CharControl.ButtonY.canceled += context => ReleaseY();

        controls.CharControl.ShoulderL.performed += context => PressShoulderL();
        controls.CharControl.ShoulderL.canceled += context => ReleaseShoulderL();

        controls.CharControl.ShoulderR.performed += context => PressShoulderR();
        controls.CharControl.ShoulderR.canceled += context => ReleaseShoulderR();

        controls.CharControl.TriggerL.performed += context => PressTriggerL();
        controls.CharControl.TriggerL.canceled += context => ReleaseTriggerL();

        controls.CharControl.TriggerR.performed += context => PressTriggerR();
        controls.CharControl.TriggerR.canceled += context => ReleaseTriggerR();
   
    }
    protected void OnEnable()
    {
        controls.CharControl.Enable();
    }

    protected void OnDisable()
    {
        controls.CharControl.Disable();
    }

    protected void Move(InputAction.CallbackContext context)
    {
        movement = new Vector3(context.ReadValue<Vector2>().x, 0, context.ReadValue<Vector2>().y);
        inputMagnitude = context.ReadValue<Vector2>().magnitude;
    }

    protected void Stop(InputAction.CallbackContext context)
    {
        movement = Vector3.zero;
        inputMagnitude = 0;
    }

    protected virtual void PressStart()
    {
        
    }

    protected virtual void ReleaseStart()
    {
        
    }

    protected virtual void PressSelect()
    {
        
    }

    protected virtual void ReleaseSelect()
    {
        
    }

    protected virtual void PressA()
    {
        
    }

    protected virtual void ReleaseA()
    {
        
    }

    protected virtual void PressB()
    {
        
    }

    protected virtual void ReleaseB()
    {
        
    }

    protected virtual void PressX()
    {
        
    }

    protected virtual void ReleaseX()
    {
        
    }

    protected virtual void PressY()
    {
        
    }

    protected virtual void ReleaseY()
    {
        
    }

    protected virtual void PressShoulderL()
    {
        
    }

    protected virtual void ReleaseShoulderL()
    {
        
    }

    protected virtual void PressShoulderR()
    {
        
    }

    protected virtual void ReleaseShoulderR()
    {
        
    }

    protected virtual void PressTriggerL()
    {
        
    }

    protected virtual void ReleaseTriggerL()
    {
        
    }

    protected virtual void PressTriggerR()
    {
        
    }

    protected virtual void ReleaseTriggerR()
    {
        
    }
}
