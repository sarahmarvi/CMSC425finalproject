using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float sensitivity = 0.3f;
    //Rigidbody rb;
    Vector3 initialPos;
    Quaternion initialQuaternion;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        initialPos = transform.position;
        initialQuaternion = transform.rotation;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            transform.rotation = initialQuaternion;
            transform.position = initialPos;
            //rb.velocity = Vector3.zero;
        }
    // Update is called once per frame
        if (Input.GetKey(KeyCode.A))
        {
            //rb.AddForce(Vector3.left);
            transform.Translate(Vector3.left * sensitivity);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //rb.AddForce(Vector3.right);
            transform.Translate(Vector3.right * sensitivity);
        }

        if (Input.GetKey(KeyCode.W))
        {
            //rb.AddForce(Vector3.forward);
            transform.Translate(Vector3.forward * sensitivity);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //rb.AddForce(Vector3.back);
            transform.Translate(Vector3.back * sensitivity);
        }
    }
}
