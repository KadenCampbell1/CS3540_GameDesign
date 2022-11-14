using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterEvent : MonoBehaviour
{
    public AIBehaviour enemy;
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            enemy.StartHunt();
        }
    }
}
