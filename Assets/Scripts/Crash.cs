using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{

    private void Update()
    {
        if (transform.position.x > 1015 || transform.position.x < -15 || transform.position.z > 1015 || transform.position.z < -15)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);      //keeping the plane in the terrain area
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("obstacle"))  //restart if we crash into obstacles
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
    
