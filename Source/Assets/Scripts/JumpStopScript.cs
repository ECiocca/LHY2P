using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpStopScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(":)");
        transform.parent.GetComponent<PlayerScript2>().isJumping = false;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        transform.parent.GetComponent<PlayerScript2>().isJumping = false;
    }

}
