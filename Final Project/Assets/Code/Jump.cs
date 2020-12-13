using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpforce = 250.0f;
    /*private bool isgrounded = true;*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpforce);
            
        }
    }

/*    void OnCollisionEnter()
    {
        isgrounded = true;
    }

    void OnCollisionExit()
    {
        isgrounded = false;
    }*/
}
