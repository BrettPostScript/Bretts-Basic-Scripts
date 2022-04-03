using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitHP : MonoBehaviour
{
	//This is the default HP value and represents the maximum hp the object can have.
    public float maxHP;
	//This value defaults to the maximum hp and can be changed through code.
    float currentHP;
    // Start is called before the first frame update
    void Start()
    {
		//set current hp to default.
        currentHP = maxHP;
    }

    public void ChangeHp(float value)
    {
		//This function changes the current hp of the object by a certain amount.
        currentHP += value;
        if (currentHP > maxHP)
            currentHP = maxHP;
		//if at any point the hp of the object reaches 0 or below, destroy the object.
        if (currentHP <= 0f)
            Destroy(gameObject);
    }

    public float GetHP()
    {
		//This code gets the current hp of the object.
		//Used in other code files.
        return currentHP;
    }
}
