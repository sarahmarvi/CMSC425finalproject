using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingWalls : MonoBehaviour
{

    public float force = 10;
    public float sensitivity = 10;
    public float timing = 3;
    Rigidbody rb;
    Vector3 startPosition;
    public GameObject emptyGameObject;
    Vector3 endPosition;
    public Transform currDoor;
    bool moved = false;
    float changeSign = 1;
    float interpolationParameter = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = currDoor.position;
        endPosition = emptyGameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        interpolationParameter = interpolationParameter + changeSign * Time.deltaTime / timing;

        // At or over one, we are on our last step.

        if (interpolationParameter >= 1 || interpolationParameter <= 0)
        {
            interpolationParameter = Mathf.Clamp(interpolationParameter, 0, 1);
            // Clamp the lerp parameter.
            moved = !moved; // Signal the loop to stop after this.
            if (!moved)
            {
                interpolationParameter = 0;
                changeSign = 1;
            }
            else
            {
                interpolationParameter = 1;
                changeSign = -1;
            }
        }

        // Set the X angle to however much rotation is done so far.

        currDoor.transform.localPosition = Vector3.Lerp(startPosition, endPosition, interpolationParameter);

    }
}