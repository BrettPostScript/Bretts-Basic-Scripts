using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScrollObject : MonoBehaviour
{
	// This vector determines how fast an object moves through 3D space along an x,y,z axis.
    public Vector3 vector;
    
    // Update is called once per frame
    void Update()
    {
		//This moves an object by the vector values at a rate of once each second.
        transform.position += vector * Time.deltaTime;
    }
}
