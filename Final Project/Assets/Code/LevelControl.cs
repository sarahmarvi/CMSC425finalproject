using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{

    public int buildIndex;

    void OnTriggerEnter(Collider item)
    {
        if (item.CompareTag("Projectile"))
        {
            SceneManager.LoadScene(buildIndex);


            //Resets Scene from begining
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
