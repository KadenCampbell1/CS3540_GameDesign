using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    public GameObject player;
    public float xAdjust = 0f, yAdjust = 1.5f;
    
    private bool facingRight = true;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        
        if (horizontalInput > 0 && !facingRight)
        {
            FlipSprite();
        }
        
        else if (horizontalInput < 0 && facingRight)
        {
            FlipSprite();
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x + xAdjust, player.transform.position.y + yAdjust, -1.5f);
    }
    
    private void FlipSprite()
    {
        facingRight = !facingRight;
        
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
