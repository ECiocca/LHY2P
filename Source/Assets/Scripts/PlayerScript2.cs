using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript2 : MonoBehaviour
{
    public float speedX;
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

        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

		if (!isJumping && Input.GetKey(KeyCode.Space))
		{
            rb.AddForce(new Vector2(0, jumpSpeedStart));
			isJumping = true;
		}
	}

	void MoveX(bool goingRight)
	{
		if (goingRight)
		{
			rb.velocity = new Vector2(speedX, rb.velocity.y);
		}

		if (!goingRight)
		{
            rb.velocity = new Vector2(-speedX, rb.velocity.y);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(":)");
        isJumping = false;
    }
}
