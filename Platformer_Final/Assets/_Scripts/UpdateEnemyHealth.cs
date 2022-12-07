using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class UpdateEnemyHealth : MonoBehaviour
{
    public Slider healthBar;
    public IntData enemyHealth;

    private void Update()
    {
        healthBar.value = enemyHealth.value;
    }
}
