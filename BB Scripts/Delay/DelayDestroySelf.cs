using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDestroySelf : MonoBehaviour
{
	//The number of seconds before an object is destroyed.
    public float delay = 3.0f;
   
    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if(delay < 0f)
        {
            Destroy(gameObject);
        }
    }
}
