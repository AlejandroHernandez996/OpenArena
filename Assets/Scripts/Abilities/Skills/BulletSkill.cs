using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSkill : Skill
{
    private string abilityName;
    private string description;
    private GameObject owner;
    public bool onClick = true;
    
    public BulletSkill()
    {
        abilityName = "Bullet Skill";
        description = "Player learns to shoot bullets out of thin air";
    }

    public void Load(GameObject owner)
    {
        this.owner = owner;
        Debug.Log(this.owner.name);
    }

    public void OnActivation()
    {
        Object.Instantiate(Resources.Load("Prefabs/Bullet") as GameObject, owner.GetComponent<Transform>().position+Vector3.forward*2+Vector3.up,Quaternion.Euler(0,90,-90));
    }

    public override string ToString()
    {
        return abilityName + " " + description;
    }
}
