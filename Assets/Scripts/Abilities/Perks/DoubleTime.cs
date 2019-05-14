using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTime : Perk
{
    private string abilityName;
    private string description;

    public DoubleTime()
    {
        abilityName = "DoubleTime";
        description = "Doubles movement speed of character";
    }

    public void Load(GameObject owner)
    {
        owner.GetComponent<Character>().movementSpeed *= 2;
    }
    
    public override string ToString()
    {
        return abilityName + " " + description;
    }
}
