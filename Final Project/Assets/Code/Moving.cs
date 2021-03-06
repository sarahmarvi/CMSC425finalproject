﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moving : MonoBehaviour
{
    public float movementSensitivity = 0.15f;
    public float rotationSpeed = 200f;
    public float speed = 3f;
    //Rigidbody rb;
    Vector3 initialPos;
    Quaternion initialQuaternion;

    public Transform ballspawn;
    public Transform playerspawn;
    public GameObject projectile;

    AudioSource source;

    public EnergyBar energyBar;
    public Energy energy;

    public GameObject[] batteries;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        initialPos = transform.position;
        initialQuaternion = transform.rotation;
        Cursor.lockState = CursorLockMode.Locked;

        source = projectile.GetComponent<AudioSource>();
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }

        transform.Rotate(0, rotationSpeed * Time.deltaTime * Input.GetAxis("Mouse X"), 0, Space.World);
        /*
        float input = Input.GetAxis("Mouse Y");
        float rot = transform.localEulerAngles.x + (-speed * Time.deltaTime * input);
        Application.Quit();
#endif
        }

        transform.Rotate(0, speed * Time.deltaTime * Input.GetAxis("Mouse X"), 0, Space.World);
        /*
        float input = Input.GetAxis("Mouse Y");

        float rot = transform.localEulerAngles.x + (-speed * Time.deltaTime * input);

        if (rot > 45 && rot < 315 && input != 0)
        {
            if (input < 0)
            {
                rot = 45;
            }
            else
            {
                rot = 315;
            }
        }

        }

        Debug.Log(rot);
        transform.localEulerAngles = new Vector3(rot, transform.localEulerAngles.y, transform.localEulerAngles.z);
        */
        //Debug.Log(transform.localEulerAngles.x);


        if (Input.GetKey(KeyCode.R))
        {
            /* transform.rotation = initialQuaternion;
             transform.position = initialPos;
             projectile.SetActive(false);

             energy.init();
             energyBar.SetMaxEnergy(energy.charge);
             energyBar.SetEnergy(energy.charge);

             for (int i = 0; i < batteries.Length; i++)
             {
                 batteries[i].SetActive(true);
             }*/

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


            //rb.velocity = Vector3.zero;
        }
        // Update is called once per frame
        if (Input.GetKey(KeyCode.A))
        {
            //rb.AddForce(Vector3.left);
            transform.Translate(Vector3.left * movementSensitivity);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //rb.AddForce(Vector3.right);
            transform.Translate(Vector3.right * movementSensitivity);
        }

        if (Input.GetKey(KeyCode.W))
        {
            //rb.AddForce(Vector3.forward);
            transform.Translate(Vector3.forward * movementSensitivity);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //rb.AddForce(Vector3.back);
            transform.Translate(Vector3.back * movementSensitivity);
        }
    }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("ReflectWall"))
        {
            /*transform.position = playerspawn.position;

            source.Stop();

            energy.init();
            energyBar.SetMaxEnergy(energy.charge);
            energyBar.SetEnergy(energy.charge);

            for (int i = 0; i < batteries.Length; i++)
            {
                batteries[i].SetActive(true);
            }

            projectile.gameObject.SetActive(false);*/

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
