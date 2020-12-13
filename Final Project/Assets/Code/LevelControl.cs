using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public string levelName;

    void onTriggerEnter(Collider item)
    {
        if (item.gameObject.name == "Projectile")
        {
            SceneManager.LoadScene(levelName);


            //Resets Scene from begining
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
