using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerRestartScene : MonoBehaviour
{
	//The tag of the game object this code affects.  By default, it is the player character.
	//This is a way to create instant death zones or one hit kills for the player character.
    public string objectTag = "Player";
	
    private void OnTriggerEnter(Collider other)
    {
		//If the tag of the colliding object matches, then reload this scene.
        if (other.tag == objectTag)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
