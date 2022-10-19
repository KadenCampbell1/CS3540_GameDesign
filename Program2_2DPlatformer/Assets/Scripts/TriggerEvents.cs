using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent onTriggerEnter2DEvent;

    private void OnTriggerEnter2D(Collider2D col)
    {
        onTriggerEnter2DEvent.Invoke();
    }
}
