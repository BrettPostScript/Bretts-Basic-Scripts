using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerLoadScene : MonoBehaviour
{
	//The tag of the object that this code will work on.
    public string objectTag = "Player";
	//The scene name to load.
    public string sceneName;
	
    private void OnTriggerEnter(Collider other)
    {
		//If the object tag matches, then load the scene.
        if (other.tag == objectTag)
        {
			//If the scene name variable has something in it, then load it.
			//Otherwise, load the next scene in the build index.
            if (sceneName != "" && sceneName != null)
            {
                SceneManager.LoadScene(sceneName);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
