using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public float jump;
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
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed, 0), ForceMode2D.Impulse);
        }

    }
}
