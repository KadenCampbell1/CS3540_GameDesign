using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public IntData enemyHealth;
    public GameObject enemy, sprite;

    private void Start()
    {
        enemyHealth.SetValue(3);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            enemyHealth.IncrementValue(-1);
            if (enemyHealth.value <= 0)
            {
                Destroy(enemy);
                Destroy(sprite);
            }
        }
    }
}
