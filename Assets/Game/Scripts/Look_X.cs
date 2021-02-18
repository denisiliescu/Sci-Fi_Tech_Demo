﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look_X : MonoBehaviour
{
    [SerializeField]
    private float _sensitivity = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float _mouseX = Input.GetAxis("Mouse X");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.y += _mouseX * _sensitivity;
        transform.localEulerAngles = newRotation;
        
    }
}
