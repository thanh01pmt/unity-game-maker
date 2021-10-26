using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Translate : MonoBehaviour
{
    float speed = 1f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.fixedDeltaTime);
    }
}
