using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public static int rotateCoin = 1;
    void Update()
    {
        transform.Rotate(Vector3.right * rotateCoin);      //coins spining
    }
}
