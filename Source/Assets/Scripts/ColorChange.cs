using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    float timeLeft = 0;
    float timer;
    float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        Debug.Log("startTime" + startTime + "timer" + timer);

        if (timer >= 1)
        {
            GetComponent<SpriteRenderer>().color = new Color(55, 0, 0, 255);
            timer = 0;
        }

        else if (timer <= 0.75)
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
        }
    }
}
