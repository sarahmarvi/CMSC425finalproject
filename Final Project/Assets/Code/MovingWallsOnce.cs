using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWallsOnce : MonoBehaviour
{

    public float force = 10;
    public float sensitivity = 10;
    Rigidbody rb;
    Vector3 startPosition;
    public GameObject emptyGameObject;
    Vector3 endPosition;
    public Transform currDoor;
    bool moved = false;
    float changeSign = 1;

    AudioSource source;

    bool moving = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = currDoor.position;
        endPosition = emptyGameObject.transform.position;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col){
        if(col.gameObject.name == "Player"){
            StartCoroutine(doorMove());
            source.Play();
        }
    }

    IEnumerator doorMove(){
        // Vary this from zero to one, to interpolate between our quaternions.

        float interpolationParameter;

        // Continue animation while this is still true.

        if(moving){
            changeSign = changeSign * -1;
            moved = !moved;
            yield break;
        }
        moving = true;

        
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
        while (moving)
        {
            // Increment our "lerp" parameter according to speed and time.

            interpolationParameter = interpolationParameter + changeSign * Time.deltaTime / 5;

            // At or over one, we are on our last step.

            if (interpolationParameter >= 1 || interpolationParameter <= 0)
            {
                interpolationParameter = Mathf.Clamp(interpolationParameter, 0, 1);// Clamp the lerp parameter.
                moving = false; // Signal the loop to stop after this.
            }

            // Set the X angle to however much rotation is done so far.

            currDoor.transform.localPosition = Vector3.Lerp(startPosition, endPosition, interpolationParameter);

            // Tell Unity to start us up again at some future time.

            yield return null;
        }
        moved = !moved;
    }
}