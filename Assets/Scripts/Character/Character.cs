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

    public List<Skill> ClickSkills = new List<Skill>();

    void Start()
    {
        Skills.Add(new BulletSkill());
        Perks.Add(new DoubleTime());
        LoadAll();
        ClickSkills.Add(Skills[0] as Skill);
    }
    public void LoadAll()
    {
        AbilityLoader.LoadAbilities(Skills, gameObject);
        AbilityLoader.LoadAbilities(Perks, gameObject);
        AbilityLoader.LoadAbilities(Classes, gameObject);

    }


}
