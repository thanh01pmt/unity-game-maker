using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody2D_AddForce : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }


    void FixedUpdate()
    {
        rb.AddForce(new Vector2(100f, 0f) * Time.fixedDeltaTime);
    }
}
