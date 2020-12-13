using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Energy energyObj;
    public Slider slider;

    public void SetMaxEnergy(float energy)
    {
        energyObj.maxEnergy = energy;
        slider.maxValue = energyObj.maxEnergy;
        slider.value = energyObj.charge;
    }

    public void SetEnergy(float energy)
    {
        energyObj.charge = energy;
        slider.value = energyObj.charge;
    }

    public void updateSlider()
    {
        slider.value = energyObj.charge;
    }
}
