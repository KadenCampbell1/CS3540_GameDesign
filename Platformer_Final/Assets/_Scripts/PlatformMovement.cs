using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed = 2f;
    public int directionNum;
    public GameObject player;
    public bool canMove = false;


    void Start()
    {
        // directionNum = 0;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && canMove)
        {
            directionNum++;
            if (directionNum >= 4)
            {
                directionNum = 0;
            }
        }
    }

    void FixedUpdate()
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

        if (canMove)
        {
            transform.position += movement *Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = transform;
            canMove = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = null;
            canMove = false;
        }
    }
}
