using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpStopScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(":)");
        transform.parent.GetComponent<PlayerScript2>().isJumping = false;
    }
}
