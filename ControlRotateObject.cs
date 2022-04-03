using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRotateObject : MonoBehaviour
{
	//Get whether the controls for rotating this object is a vertical control or horizontal.
	//Horizontal = A,D,Left,Right
	//Vertical = W,S,Up,Down
    public enum inputAxis { Horizontal, Vertical };
    public inputAxis axis;
	//This vector describes the speed at which the object rotates along an x,y,z axis.
	//An x value of 5 means the object will rotate 5 degrees along the x axis each second.
    public Vector3 vector;

    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vector * Input.GetAxis(axis.ToString()) * Time.deltaTime);
    }
}
