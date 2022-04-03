using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitObjectForce : MonoBehaviour
{
	//Speed at which the object moves.
    public float speed;
	//How the speed value interacts with the object via force.
    public ForceMode forceMode;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed, forceMode);
    }
}
