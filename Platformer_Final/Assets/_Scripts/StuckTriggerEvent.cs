using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuckTriggerEvent : MonoBehaviour
{
    public PlatformMovement platform;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stuck"))
        {
            platform.SetStuck(true);
        }
    }
}
