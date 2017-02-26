using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJHCloud : MonoBehaviour {
    public float speed = 3.0f;
    public float startPosition;
    public float endPosition = -15.0f;

    void Awake()
    {
        startPosition = transform.position.x;       
    }

    void Update()
    {
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

        if (transform.position.x <= endPosition)
            ScrollEnd();

        speed += 0.001f;
    }
    void ScrollEnd()
    {
        transform.Translate(-1 * (endPosition - 65.0f), 0, 0);       
    }
}
