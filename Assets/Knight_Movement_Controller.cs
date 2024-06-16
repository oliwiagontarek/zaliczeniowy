using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Movement_Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    private bool isGrounded = false;
    private readonly float moveSpeed = 5f;
    private readonly float upForce = 500f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * upForce);
            isGrounded = false;
        }


        float velocityX = Input.GetAxis("Horizontal") * moveSpeed;

        rb.velocity = new Vector2(velocityX, rb.velocity.y);

        animator.SetBool("IsMoving", velocityX != 0);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Danger"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}