using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Position : MonoBehaviour
{
    float speed = 1f; 
    void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(speed*Time.fixedDeltaTime, 0f, 0f) ;
    }
}
