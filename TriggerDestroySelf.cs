using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestroySelf : MonoBehaviour
{
	//This code file is almost exclusively for projectiles that damage objects they collide with.
	
	//the amount of hp to change in the object that collides with this object.
    public float changeHP;
    private void OnTriggerEnter(Collider other)
    {
		//Change the hp of the object that collides with this object.
		//Not every object will have hp.  If the colliding object does not, this object will merely only destroy itself.
        other.gameObject.SendMessage("ChangeHp", changeHP, SendMessageOptions.DontRequireReceiver);
		//Then, destroy this game object.
        Destroy(gameObject);
    }
}
