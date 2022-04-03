using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLookAtMouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
		//Gets the mouse position on the screeen.
        Vector3 mouse = Input.mousePosition;
		//Converts the mouse screen position to a point in the world aligned with this game object.
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(
                                                            mouse.x,
                                                            mouse.y,
                                                            gameObject.transform.position.y));
		//Normalizes the mouse coordinate to be at the same level as this game object in terms of height.
        mouseWorld = new Vector3(mouseWorld.x, gameObject.transform.position.y, mouseWorld.z);
		//Rotates this game object to look at the mouse point.
        transform.LookAt(mouseWorld);
    }
}
