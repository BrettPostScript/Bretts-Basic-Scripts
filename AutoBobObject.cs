using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBobObject : MonoBehaviour
{
    // User Inputs
	//The object will rotate around this many degrees per second.  Set to 0 if you do not want it to rotate.
    public float degreesPerSecond = 15.0f;
	//How far it bobs.
    public float amplitude = 0.5f;
	//How fast it bobs.
    public float frequency = 1f;

    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Use this for initialization
    void Start()
    {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Spin object around Y-Axis
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}
