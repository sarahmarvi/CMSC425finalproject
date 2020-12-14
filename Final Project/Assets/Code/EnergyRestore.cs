using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyRestore : MonoBehaviour
{
    public Energy energy;
    public EnergyBar slider;
    private bool isTriggered = false;
    
    void OnEnable()
    {
        isTriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
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
