using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterAnimation animation;
    public CharController controller;
    private float deadzone = 0.1f;
    private float turnSmoothVelocity;
    private float turnSpeed = 0.1f;
    private void Update()
    {
        Move(controller.movement, controller.inputMagnitude);
    }
    public void MoveUp()
    {

    }
    public void MoveDown()
    {

    }
    private void Move(Vector3 direction, float inputMagnitude)
    {
        Transform cam = Camera.main.transform;
        if (inputMagnitude > deadzone)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSpeed);
            Vector3 adjustedDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            Turn(angle);
            transform.position += adjustedDirection * Time.deltaTime * inputMagnitude;
        }
        else
        {

        }
    }

    public void TurnTowards(Vector3 targetPos)
    {
        Vector3 direction = targetPos - transform.position;
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSpeed);
        Turn(angle);
    }
    public void Turn(float angle)
    {
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }
}
