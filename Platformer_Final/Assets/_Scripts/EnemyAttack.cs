using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject player;
    public IntData playerHealth;
    public LoseData lose;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerHealth.value--;
            if (playerHealth.value <=0)
            {
                lose.Lose();
            }
        }
    }
}
