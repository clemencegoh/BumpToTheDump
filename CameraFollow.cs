﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    private int depth = -10;
    private int height = 15;

    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null)
        {
            transform.position = playerTransform.position + new Vector3(0, height, depth);
        }
    }

    public void setTarget(Transform target)
    {
        playerTransform = target;
    }
}
