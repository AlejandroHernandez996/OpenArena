using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class AbilityLoader
{
    public static void LoadAbilities(List<Ability> abilities, GameObject owner)
    {
        if (abilities == null)
        {
            throw new System.ArgumentNullException(nameof(abilities));
        }

        foreach (var ability in abilities)
        {
            ability.Load(owner);
            Debug.Log("Loaded " + ability.ToString());
        }
    }
}
