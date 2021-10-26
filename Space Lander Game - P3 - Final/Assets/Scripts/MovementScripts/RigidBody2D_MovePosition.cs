using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody2D_MovePosition : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 0.1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.gravityScale = 0; //or change to Kinematic
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2 (1f, 0f) * Time.fixedDeltaTime);
    }
}
