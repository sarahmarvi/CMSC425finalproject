using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallActivate : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        ball.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            ball.SetActive(true);
        }
    }
}
