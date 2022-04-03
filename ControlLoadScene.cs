using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlLoadScene : MonoBehaviour
{
	//This minimum delay is to avoid skipping the scene entirely.
	//Essentially, keypresses will not be valid until this many seconds have passed.
    float delay = 1.0f;
	//The name of the scene to load.
    public string sceneName;
    
    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (delay < 0f)
        {
			//If the player presses any key on their keyboard, then load the scene.
            if (Input.anyKeyDown)
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
}
