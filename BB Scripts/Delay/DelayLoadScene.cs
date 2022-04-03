using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayLoadScene : MonoBehaviour
{
	//The number of seconds before the new scene loads.
    public float delay = 2.0f;
	//The name of the scene.
    public string sceneName;
    
    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (delay < 0f)
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
