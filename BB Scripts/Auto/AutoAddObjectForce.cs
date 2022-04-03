using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAddObjectForce : MonoBehaviour
{
	//This factor decides the direction along an x,y,z axis that the object moves.
	//The number correlates to the speed.
    public Vector3 vector;
	//This forcemode determines how the vector speed value interacts with the object.
    public ForceMode forceMode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(vector, forceMode);
    }
}
