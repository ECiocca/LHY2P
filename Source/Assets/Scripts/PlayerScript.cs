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

        if (isJumping == false)
        {
            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector2(rb.velocity.x + aceleration, 0);
                rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, 0, maxSpeed), rb.velocity.y);
            }

            else if (Input.GetKey(KeyCode.A))
            {
                rb.velocity = new Vector2(rb.velocity.x - aceleration, 0);
                rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -maxSpeed, 0), rb.velocity.y);
            }

            else
            {
                if(rb.velocity.x > 0)
                {
                    rb.velocity = new Vector2(rb.velocity.x * decay * Time.deltaTime, rb.velocity.y);
                }

                if (rb.velocity.x < 0)
                {
                    rb.velocity = new Vector2(rb.velocity.x * decay * Time.deltaTime, rb.velocity.y);
                }
            }
        }
    }
}