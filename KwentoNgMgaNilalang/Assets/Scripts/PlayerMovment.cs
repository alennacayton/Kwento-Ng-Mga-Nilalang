using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    private Rigidbody2D rigidBody2D;
    private Vector2 moveInput;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }

    void OnMove(InputValue value)
    {
        Vector2 moveValue = value.Get<Vector2>();

        /*
         *  Used if you don't want the player to move diagonally
        if (moveValue.x != 0 && moveValue.y != 0)
            return;
        */

        moveInput = moveValue;
        Debug.Log(moveInput);
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
        rigidBody2D.velocity = playerVelocity;

        if(moveInput.x == 0 && moveInput.y == 0)
        {
            animator.SetInteger("walking", 0);
        }
        else if(moveInput.x == 0 && moveInput.y == 1)
        {
            animator.SetInteger("walking", 1);
        }
        else if(moveInput.x == 1 && moveInput.y == 0)
        {
            animator.SetInteger("walking", 2);
        }
        else if (moveInput.x == 0 && moveInput.y == -1)
        {
            animator.SetInteger("walking", 3);
        }
        else if (moveInput.x == -1 && moveInput.y == 0)
        {
            animator.SetInteger("walking", 4);
        }


    }
}
