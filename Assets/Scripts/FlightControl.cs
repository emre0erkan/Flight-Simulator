using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlightControl : MonoBehaviour
{
    public static float speed;
    public float maxspeed;
    public float minspeed;
    public float rotspeed1;
    public float rotspeed2;
    public float rotspeed3;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void FixedUpdate()
    {
        Vector3 moveCamTo = transform.position - transform.forward * 5f + Vector3.up * 10f;
        float bias = 0.96f;
        cam.transform.position = cam.transform.position * bias + moveCamTo * (1f - bias);    //make the camera follow the plane
        cam.transform.LookAt(transform.position + transform.forward * 25f);                  //smooth camera movement

        transform.position += transform.forward * Time.deltaTime * speed;

        speed -= transform.forward.y * Time.deltaTime * 50f;    //speed adjustment with directing up or down
        if (speed < minspeed) speed = minspeed;
        if (speed > maxspeed) speed = maxspeed;

        if (Input.GetKey(KeyCode.W))              //key input settings beyond this
        {
            if (speed < maxspeed) speed++;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            if (speed > minspeed) speed--;
        }

        if (Input.GetKey(KeyCode.Keypad4))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotspeed3);
        }

        if (Input.GetKey(KeyCode.Keypad6))
        {
            transform.Rotate(Vector3.back * Time.deltaTime * rotspeed3);
        }

        if (Input.GetKey(KeyCode.Keypad5))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * rotspeed1);
        }

        if (Input.GetKey(KeyCode.Keypad8))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * rotspeed1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * rotspeed2);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.down * Time.deltaTime * rotspeed2);
        }

    }

}
