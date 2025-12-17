using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public Rigidbody rigid;
    public WheelCollider wheel1, wheel2, wheel3, wheel4;
    public float drivespeed, steerspeed;
    float horizontalInput, verticalInput;

    void Update()
    {   


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        float motor = Input.GetAxis("Vertical") * drivespeed;
        //Debug.Log(motor);
        wheel1.motorTorque = motor;
        wheel2.motorTorque = motor;
        wheel3.motorTorque = motor;
        wheel4.motorTorque = motor;
        wheel1.steerAngle = steerspeed * horizontalInput;
        wheel2.steerAngle = steerspeed * horizontalInput;

        if (verticalInput == 0)
        {
            wheel1.brakeTorque = 5000;
            wheel2.brakeTorque = 5000;
            wheel3.brakeTorque = 5000;
            wheel4.brakeTorque = 5000;
        }
        else
        {
            wheel1.brakeTorque = 0;
            wheel2.brakeTorque = 0;
            wheel3.brakeTorque = 0;
            wheel4.brakeTorque = 0;
        }

    }
}