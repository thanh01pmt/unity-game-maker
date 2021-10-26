using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector2_SmoothDamp : MonoBehaviour
{
    float smoothTimeScale = 100f;
    Vector2 targetPosition;
    Vector2 velocity = Vector2.zero;
    private void Start()
    {
        targetPosition = new Vector2(transform.position.x + 11, transform.position.y);
    }
    void FixedUpdate()
    {
        transform.position = Vector2.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTimeScale * Time.fixedDeltaTime);
    }
}
