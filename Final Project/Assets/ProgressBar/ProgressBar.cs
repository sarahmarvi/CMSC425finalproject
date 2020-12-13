using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{

    public int minimum = 0;
    public int maximum = 100;
    public int current = 100;
    public Image mask = null;


    // Update is called once per frame
    void Update()
    {
        getCurrentFill();
    }

    void getCurrentFill()
    {
        float calcFillAmount = (float)current / (float)maximum;
        mask.fillAmount = calcFillAmount;
    }
}
