using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float forwardInput;    
    
    // Update is called once per frame
    void Update()
    {   
        // get the input from w, s, arrow up and arrow down                 
        horizontalInput = Input.GetAxis("Horizontal");

        // get input from a, d, arrow left and arrow right
        forwardInput = Input.GetAxis("Vertical");

        //multiply Vector.forward(0, 0, 1) to time between frames, speed, and forwardInput to move forward (if equals 0, stays still)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotate to make curves
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnSpeed);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed *horizontalInput);
    }
}
