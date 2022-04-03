using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLerpToTransform : MonoBehaviour
{
	//Drag your target game object into this slot in the inspector and this object will move toward it.
	//Lerping means your object will move quickly when far away and slowly when closer.
	//Lerp = Linear Interpolation
    public Transform target;
	//How fast it lerps
    public float speed = 0.2f;
	//Set this to true to have your object default to lerping to the object tagged "Player"
    public bool overrideToPlayer;
    // Start is called before the first frame update
    void Start()
    {
        if (overrideToPlayer == true)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
		//This is the core lerp code.  We are altering the position of this object by a small amount each time.
        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
    }
}
