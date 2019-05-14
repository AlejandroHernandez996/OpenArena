using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private float speed;
    private float jumpHeight;
    private bool canJump;

    void Start()
    {
        speed = gameObject.GetComponent<Character>().movementSpeed;
        jumpHeight = gameObject.GetComponent<Character>().jumpHeight;
        canJump = false;
    }

    void FixedUpdate()
    {

        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);

        if(canJump && Input.GetKeyUp(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }
}
