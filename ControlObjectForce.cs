using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlObjectForce : MonoBehaviour
{
	//This is the core player movement control.
	//This enum gets the type of control.  You will need to use a separate component of this code for each kind of input.
	//Horizontal = A,D,Left,Right
	//Vertical = W,S,Up,Down
	//Jump = Spacebar
    public enum inputButton { Horizontal, Vertical, Jump };
    public inputButton button;
	//This vector represents the speed along an axis that the controls move the object along.
	//value = speed
    public Vector3 vector;
	//How the speed vector interacts with the object via force.
    public ForceMode forceMode;
	//This bool is true for jumping controls that require the game object be touching the ground in order to jump.
	//It negates double jumping or infinite flight.
    public bool requiresGround;
    
    // Update is called once per frame
    void Update()
    {
		//If the control is horizontal or vertical, then move the object.
		//Otherwise, do some jumping.
        if (button == inputButton.Horizontal || button == inputButton.Vertical)
        {
            GetComponent<Rigidbody>().AddForce(vector * Input.GetAxis(button.ToString()) * Time.deltaTime, forceMode);
        }
        else
        {
			//If the jump mechanic requires ground to jump off of, then jump.
			//Otherwise, the object can jump infinitely.
            if (requiresGround == true)
            {
                if(Mathf.Abs(GetComponent<Rigidbody>().velocity.y) < 0.15f)
                    if (Input.GetButtonDown(button.ToString()))
                        GetComponent<Rigidbody>().AddForce(vector * Time.deltaTime, forceMode);
            }
            else
            {
                if (Input.GetButton(button.ToString()))
                    GetComponent<Rigidbody>().AddForce(vector * Time.deltaTime, forceMode);
            }

        }
    }
}
