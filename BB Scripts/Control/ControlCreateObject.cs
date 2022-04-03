using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCreateObject : MonoBehaviour
{
	//Draw the prefab you want to spawn here in the inspector.
    public GameObject spawn;
	//the delay in seconds between spawns as long as the player is firing.
    public float delay;
	//This timer decrements by 1 each second.  When it reaches 0, it resets to the delay value.
    float delayTimer;
	//Keep this variable the same unless you have a custom button.  "Fire1" is already mapped in the default controls.
    string button = "Fire1";
	//Set to true if you want the spawned prefab to be aligned with this object's forward vector.
	//Essentially good for things like projectiles.
    public bool facingForward;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delayTimer -= Time.deltaTime;
        if (delayTimer < 0 && Input.GetButton(button))
        {
            delayTimer = delay;
            if (facingForward == false)
                GameObject.Instantiate(spawn, transform.position, Quaternion.identity);
            else
                GameObject.Instantiate(spawn, transform.position, transform.rotation);
        }
    }
}
