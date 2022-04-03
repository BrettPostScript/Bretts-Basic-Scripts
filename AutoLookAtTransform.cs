using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLookAtTransform : MonoBehaviour
{
	//The target location of the object.  Simply drag a target game object into this slot in the inspector.
    public Transform target;
	//Set this to true if you want the object to default to looking at the object tagged "Player";
    public bool overrideToPlayer;
    // Start is called before the first frame update
    void Start()
    {
        if(overrideToPlayer == true)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }
}
