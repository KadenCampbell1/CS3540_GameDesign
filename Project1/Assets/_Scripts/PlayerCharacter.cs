using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int health = 5;
    public GameObject lose;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 1;
    }

    public void Hurt(int damage)
    {
        health -= damage;
        Debug.Log($"Health: {health}");
        if (health <= 0)
        {
            lose.GetComponent<LoseCondition>().hasLost = true;
            Destroy(this.gameObject);
        }
    }
}
