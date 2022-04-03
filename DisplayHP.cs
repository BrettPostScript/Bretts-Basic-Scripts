using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHP : MonoBehaviour
{
	//Drag the gameobject that contains the InitHP script on it into this slot in the inspector.
    public InitHP hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//Displays the hp of the game object through a UI text object on a canvas.
        GetComponent<Text>().text = "" + (int)hp.GetHP();
    }
}
