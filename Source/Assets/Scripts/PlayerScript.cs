using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float aceleration;
    public float decay;
    public float maxSpeed;
    public float jumpSpeedStart;
    public float jumpSpeedDecay;
    public float jumpXSpeed;
    float rayCheckDistance;
    float jumpSpeed;
    public bool isJumping = false;
    public GameObject rayOrigin;
    public Collider2D tilemapCollider;
    Rigidbody2D rb;
    RaycastHit2D raycastHit;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        //moves the player on the X axis
        if (Input.GetKey(KeyCode.D))
        {
            MoveX(true); //true means right
        }

        else if (Input.GetKey(KeyCode.A))
        {
            MoveX(false); //false means left
        }

        if(!isJumping && Input.GetKey(KeyCode.Space))
        {
            jumpSpeed = jumpSpeedStart;
            isJumping = true;
        }

        if (isJumping)
        {
            Debug.Log("jumpSpeed " + jumpSpeed);
            jumpSpeed -= (jumpSpeedDecay * Time.deltaTime);
            Debug.Log("jumpSpeed after decay " + jumpSpeed);
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + Mathf.Clamp(jumpSpeed * Time.deltaTime, 0, jumpSpeedStart));
        }
    }

    void MoveX(bool goingRight)
    {
        if (goingRight)
        {
            rb.velocity = new Vector2(rb.velocity.x + aceleration, rb.velocity.y);
            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, 0, maxSpeed), rb.velocity.y);
        }

        if (!goingRight)
        {
            rb.velocity = new Vector2(rb.velocity.x - aceleration, rb.velocity.y);
            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -maxSpeed, 0), rb.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }
}