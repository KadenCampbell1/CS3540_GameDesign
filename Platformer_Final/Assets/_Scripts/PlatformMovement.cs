using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed = 2f;
    public int directionNum;
    public GameObject player;


    void Start()
    {
        // directionNum = 0;
    }
    
    
    void Update()
    {
        Vector3 movement = new Vector3(0, 0, 0);
        
        if (directionNum == 0)
        {
            movement = new Vector3(speed, 0, 0);
        }
        else if (directionNum == 1)
        {
            movement = new Vector3(0, -speed, 0);
        }
        else if (directionNum == 2)
        {
            movement = new Vector3(-speed, 0, 0);
        }
        else if (directionNum == 3)
        {
            movement = new Vector3(0, speed, 0);
        }
        
        if (Input.GetButtonDown("Jump"))
        {
            directionNum++;
            if (directionNum >= 4)
            {
                directionNum = 0;
            }
        }
        
        transform.position += movement *Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = null;
        }
    }
}
