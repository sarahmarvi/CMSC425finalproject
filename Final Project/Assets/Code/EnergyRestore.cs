﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyRestore : MonoBehaviour
{
    public Energy energy;
    public EnergyBar slider;
    private bool isTriggered = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!isTriggered)
            {
                energy.restoreEnergy();
                isTriggered = true;
                gameObject.SetActive(false);
                slider.updateSlider();
            }
        }
    }
}