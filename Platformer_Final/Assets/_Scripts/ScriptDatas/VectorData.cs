using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class VectorData : ScriptableObject
{
    public Vector3 value;
    
    public void SetValue(Vector3 obj)
    {
        value = obj;
    }
}