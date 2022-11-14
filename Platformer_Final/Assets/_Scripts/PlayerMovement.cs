using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement, lookDirection;
    private float gravity = -40f, yAxisVar;
    private int jumpCount;

    public GameObject canJumpPlatform;
    public float speed, normalSpeed, fastSpeed, jumpForce;
    public int jumpMax;
    public bool canJump = true;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
        speed = normalSpeed;
    }

    private void Update()
    {
        yAxisVar += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yAxisVar = -1;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpMax && canJump)
        {
            yAxisVar = jumpForce;
            jumpCount++;
        }
        
        var horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Fire3"))
        {
            speed = fastSpeed;
        }
        else if (Input.GetButtonUp("Fire3"))
        {
            speed = normalSpeed;
        }
        
        movement.Set(horizontalInput * (speed), yAxisVar, 0);
        controller.Move(movement * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == canJumpPlatform)
        {
            canJump = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == canJumpPlatform)
        {
            canJump = true;
        }
    }
}
