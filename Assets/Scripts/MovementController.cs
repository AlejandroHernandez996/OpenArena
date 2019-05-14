using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private float speed;
    private float jumpHeight;

    void Start()
    {
        speed = gameObject.GetComponent<Character>().movementSpeed;
        jumpHeight = gameObject.GetComponent<Character>().jumpHeight;
    }

    void FixedUpdate()
    {

        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
