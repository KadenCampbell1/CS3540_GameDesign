using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public VectorData loc;
    public VectorData newLoc;
    public GameObject player;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            loc.SetValue(newLoc.value);
        }
    }
}
