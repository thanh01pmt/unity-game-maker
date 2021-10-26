using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody2D_Velocity : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate() //Better than Update()
    {
        rb.velocity = new Vector2(1f, 0f);
    }
}
