using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]float speed = 5f;

    Rigidbody2D rb2d;
    CapsuleCollider2D cc2D;
    Vector2 moveInput;
    Animator animator;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        cc2D = GetComponent<CapsuleCollider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();    
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * speed, moveInput.y * speed);
        rb2d.velocity = playerVelocity;

        bool playerHasHorizonTalSpeed = Mathf.Abs(rb2d.velocity.x) > Mathf.Epsilon;
        bool playerHasVeticalSpeed = Mathf.Abs(rb2d.velocity.y) > Mathf.Epsilon;
        bool playerMoving = playerHasHorizonTalSpeed || playerHasVeticalSpeed;
        animator.SetBool("isWalking", playerMoving);
        animator.SetFloat("moveX",moveInput.x);
        animator.SetFloat("moveY", moveInput.y);
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
