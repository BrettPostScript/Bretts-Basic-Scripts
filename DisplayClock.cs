using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayClock : MonoBehaviour
{
	//Drag the game object that contains the InitClock script to this slot in the inspector.
    public InitClock clock;
	//Set this to true if you merely want to display the best time, rather than a changing timer.
	//Useful for an end screen that displays a best time after the level is complete.
    public bool isBestTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isBestTime == false)
            GetComponent<Text>().text = "" + (int)clock.GetSeconds();
        else
            GetComponent<Text>().text = "" + (int)PlayerPrefs.GetFloat("BestTime");
    }
}
