using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach(var skill in GetComponent<Character>().ClickSkills)
            {
                skill.OnActivation();
            }
        }
    }
}
