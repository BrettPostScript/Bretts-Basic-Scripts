using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChangeHP : MonoBehaviour
{
	//the amount of hp this object changes when it collides with a game object.
	//This is useful for immobile hazards or field effects of damage.
    public float changeHP;
	
    private void OnTriggerEnter(Collider other)
    {
		//This object will send a message to try to change the hp of a colliding game object.
		//Not all game objects have hp, so this will do nothing for lacking game objects.
        other.gameObject.SendMessage("ChangeHp", changeHP, SendMessageOptions.DontRequireReceiver);
    }
}
