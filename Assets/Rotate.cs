using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatee : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.rotateeAround(Vector3.up,Vector3.left,40*Time.deltaTime); 
    }
}
