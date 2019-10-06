using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public float jumpSpeedStart;
    public float jumpSpeedDecay;
    float jumpSpeed;
    public bool isJumping = false;
    public GameObject rayOrigin;
    public float rayCheckDistance;
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
            if (Input.GetKey(KeyCode.Space))
            {
                isJumping = true;
                jumpSpeed = jumpSpeedStart;
            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(new Vector2(speed, 0), ForceMode2D.Force);
            }

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(new Vector2(-speed, 0), ForceMode2D.Force);
            }
        }

        if (isJumping == true)
        {

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(new Vector2(speed/2, 0), ForceMode2D.Force);
            }

            else if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(new Vector2(-speed/2, 0), ForceMode2D.Force);
            }

            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Force);
            jumpSpeed = Mathf.Clamp(jumpSpeed - (Time.deltaTime * jumpSpeedDecay), 0, jumpSpeedStart);
        }

        Debug.Log("speedY " + GetComponent<Rigidbody2D>().velocity.y);
        if(Mathf.Abs(GetComponent<Rigidbody2D>().velocity.y) == 0)
        {
            isJumping = false;
        }
    }
}