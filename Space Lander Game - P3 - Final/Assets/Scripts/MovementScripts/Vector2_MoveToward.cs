using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector2_MoveToward : MonoBehaviour
{
    float speed = 1f;
    Vector2 targetPosition;

    private void Start()
    {
        targetPosition = new Vector2(transform.position.x + 11, transform.position.y);
    }

    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.fixedDeltaTime);
    }
}
