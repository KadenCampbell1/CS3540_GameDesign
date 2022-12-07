using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed = 2f;
    public int directionNum;
    public GameObject player;
    public GameObject[] directionCube;
    public bool canMove = false, stuck = false;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && canMove)
        {
            int i = directionNum;
            if (stuck)
            {
                directionNum += 1;
            }
            stuck = false;
            if (i >= 4)
            {
                i = 0;
            }
            directionCube[i].SetActive(false);
            if (directionNum >= 4)
            {
                directionNum = 0;
            }
            directionCube[directionNum].SetActive(false);
            directionNum++;
            if (directionNum >= 4)
            {
                directionNum = 0;
            }
            directionCube[directionNum].SetActive(true);
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

        if (canMove && !stuck)
        {
            transform.position += movement *Time.deltaTime;
        }
    }

    public void SetStuck(bool value)
    {
        stuck = value;
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
