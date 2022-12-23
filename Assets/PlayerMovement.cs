using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rbody;
    float hInput;
    public float force;

    void Awake()
    {
        rbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        if (hInput != 0)
        {
            rbody.AddForce(new Vector3(hInput, 0, 0) * force);
            hInput = 0;
        }
    }
}
