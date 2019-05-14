using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    public int stamina;
    public float movementSpeed;
    public float jumpHeight;

    public List<Ability> Classes = new List<Ability>();
    public List<Ability> Skills = new List<Ability>();
    public List<Ability> Perks = new List<Ability>();

    void Start()
    {
        AddPerk(new DoubleTime());
        LoadAll();
    }
    public void LoadAll()
    {
        AbilityLoader.LoadAbilities(Skills, this);
        AbilityLoader.LoadAbilities(Perks, this);
        AbilityLoader.LoadAbilities(Classes, this);
    }

    public void AddSkill(Ability ability)
    {
        Skills.Add(ability);
    }

    public void AddClass(Ability ability)
    {
        Classes.Add(ability);
    }

    public void AddPerk(Ability ability)
    {
        Perks.Add(ability);
    }
}
