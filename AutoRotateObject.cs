using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotateObject : MonoBehaviour
{
	//This vector describes the amount of rotation on any or all axis' along an x,y,z.
	//An x value of 20 means it will rotate 20 degrees every second along the x axis.
    public Vector3 vector;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vector * Time.deltaTime);
    }
}
