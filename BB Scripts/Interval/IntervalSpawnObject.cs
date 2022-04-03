using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntervalSpawnObject : MonoBehaviour
{
	//The number of seconds between spawns.
    public float interval;
	//A timer that counts down and resets to the default interval value.
    float intervalTimer;
	//Set to true if you want the spawned object to orient to this objects forward facing vector.
	//Useful for projectiles.
    public bool facingForward;
	//Set to true if you want the spawned object to spawn in its original transform position, rather than
	//at this object's position.
    public bool keepOriginalTransform;
	//An array that houses a collection of game objects to spawn.  You can have just one object stored here or up to
	//as many as you like.  The spawner will spawn 1 of these objects at random each interval.
    public GameObject[] spawns;

    private void Start()
    {
        InitTimer();
            

    }

    // Update is called once per frame
    void Update()
    {
        intervalTimer -= Time.deltaTime;
        if (intervalTimer < 0f)
        {
            InitTimer();
            if (facingForward == false)
            {
                if (keepOriginalTransform == false)
                    GameObject.Instantiate(spawns[Random.Range(0, spawns.Length)], transform.position, Quaternion.identity);
                else
                    GameObject.Instantiate(spawns[Random.Range(0, spawns.Length)]);
            }
            else
            {
                GameObject.Instantiate(spawns[Random.Range(0, spawns.Length)], transform.position, transform.rotation);
            }
        }
    }

    void InitTimer()
    {
        intervalTimer = interval;
    }
}
