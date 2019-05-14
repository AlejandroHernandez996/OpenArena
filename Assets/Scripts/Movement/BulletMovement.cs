using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float force;
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
    }

}
