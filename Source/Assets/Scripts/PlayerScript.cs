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

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-maxSpeed, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(maxSpeed, 0));
        }
    }
}