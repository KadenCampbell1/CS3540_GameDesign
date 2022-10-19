using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private Collider2D col;
    [SerializeField] private LayerMask ground;
    private enum player_state
    {
        Idle,
        Run,
        Jump,
        Fall
    }
    private player_state p_state = player_state.Idle;

    public float speed = 5;
    public float jump_height = 10;
    public bool can_fly = false;
    public float hold_time = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        col = GetComponent<Collider2D>();
    }

    private void Update()
    {
        float h_direction = Input.GetAxis("Horizontal");
        if (h_direction < 0)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            transform.localScale = new Vector2(-1, 1);
        }
        
        else if (h_direction > 0)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            transform.localScale = new Vector2(1, 1);
        }

        if (!can_fly)
        {
            if (Input.GetButtonDown("Jump") && col.IsTouchingLayers(ground))
            {
                rb.velocity = new Vector2(rb.velocity.x, jump_height);
                p_state = player_state.Jump;
            }
        }
        else
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector2(rb.velocity.x, jump_height);
                p_state = player_state.Jump;
            }
        }

        StateChange();
        anim.SetInteger("player_state", (int)p_state);
        
    }

    private void StateChange()
    {
        if (p_state == player_state.Jump)
        {
            if (rb.velocity.y < 0.1f)
            {
                p_state = player_state.Fall;
            }
        }
        else if (p_state == player_state.Fall)
        {
            if (col.IsTouchingLayers(ground))
            {
                p_state = player_state.Idle;
            }
        }
        else if (Mathf.Abs(rb.velocity.x) > 2f)
        {
            p_state = player_state.Run;
        }
        else
        {
            p_state = player_state.Idle;
        }
    }

    public void SetCanFly(bool fly)
    {
        can_fly = fly;
        StartCoroutine(Fly());

    }

    private IEnumerator Fly()
    {
        yield return new WaitForSeconds(hold_time);
        SetCanFly(false);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform"))
        {
            transform.parent = col.gameObject.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            transform.parent = null;
        }
    }
}
