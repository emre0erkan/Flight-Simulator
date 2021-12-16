using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{

    public static int rotateAmount = 20;
    void Update()
    {
        transform.Rotate(Vector3.up * rotateAmount);          //simply rotate the propeller

        if (FlightControl.speed< 80) rotateAmount = 3;
        if (FlightControl.speed < 120 && FlightControl.speed > 80) rotateAmount = 7;    //propeller speed
        if (FlightControl.speed > 120) rotateAmount = 15;
    }
}
