using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class AbilityLoader
{
    public static void LoadAbilities(List<Ability> abilities, Character character)
    {
        foreach(var ability in abilities)
        {
            Debug.Log("Hello");
            ability.Load(character);
        }
    }
}
