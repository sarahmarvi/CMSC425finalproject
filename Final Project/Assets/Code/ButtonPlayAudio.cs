using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlayAudio : MonoBehaviour
{
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision item)
    {
        if (item.gameObject.CompareTag("Player"))
        {
            source.Play();
        }
        
    }

}
