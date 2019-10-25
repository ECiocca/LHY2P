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
    bool isJumping = false;
    public GameObject rayOrigin;
    Rigidbody2D rb;
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

        //checks if the player is jumping grounded or falling
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
}