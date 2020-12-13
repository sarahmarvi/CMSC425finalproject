using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    bool moving;
    private Rigidbody rb;

    void Start()
    {
        //moving = false;
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.back*speed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = speed * (rb.velocity.normalized);
        if(moving == true)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if(moving == false)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
           
                moving = true;
            }

        }
        
    }
}
