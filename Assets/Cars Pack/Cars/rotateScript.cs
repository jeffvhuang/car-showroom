﻿using UnityEngine;

public class rotateScript : MonoBehaviour
{
    private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
