using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector2_Lerp : MonoBehaviour
{
    float speed = 1f;
    Vector2 targetPosition;

    private void Start()
    {
        targetPosition = new Vector2(transform.position.x + 11f, transform.position.y);
        Debug.Log(targetPosition);
    }
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, new Vector2(5.5f, -3.3f), speed * Time.fixedDeltaTime);
    }
}