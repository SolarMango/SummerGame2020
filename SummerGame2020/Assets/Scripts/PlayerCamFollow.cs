﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamFollow : MonoBehaviour
{
    public Transform PlayerTransform;
    public Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool isLookingAtPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - PlayerTransform.position;
    }

    // LateUpdate is called after Update methods
    void LateUpdate()
    {
        Vector3 newPos = PlayerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (isLookingAtPlayer)
        {
            transform.LookAt(PlayerTransform);
        }
    }
}
