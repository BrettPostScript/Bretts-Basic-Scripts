using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitClock : MonoBehaviour
{
	//holds the number of seconds that have passed and also acts as a starting value.
    public float seconds;
	//Set to true if the clock is counting forward.
	//Set to false if the clock is counting backwards.
    public bool forward;
    
    // Update is called once per frame
    void Update()
    {
        if (forward == true)
            seconds += Time.deltaTime;
        else
            seconds -= Time.deltaTime;
    }

    public float GetSeconds()
    {
        return seconds;
    }

    public void OnDestroy()
    {
		//If the object is destroyed and the time is better than the best time, then store the value as a new best time.
        if (seconds > PlayerPrefs.GetFloat("BestTime"))
            PlayerPrefs.SetFloat("BestTime", seconds);

    }
}
