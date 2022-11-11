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

    public float speed, normalSpeed, fastSpeed, jumpForce;
    public int jumpMax;
    

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

        if (Input.GetButtonDown("Jump") && jumpCount < jumpMax)
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
        
        movement.Set(horizontalInput, yAxisVar, 0);
        controller.Move(movement * (speed * Time.deltaTime));
    }
}
