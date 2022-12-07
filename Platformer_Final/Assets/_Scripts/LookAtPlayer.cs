using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform cam;
    public Camera camera;

    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        cam = camera.transform;
    }

    private void LateUpdate()
    {
        transform.LookAt(cam);
    }
}
