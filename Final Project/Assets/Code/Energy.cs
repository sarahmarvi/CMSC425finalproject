using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Values/Energy")]
public class Energy : ScriptableObject
{
    public float maxEnergy = 5f;
    public float charge;

    public void init()
    {
        charge = maxEnergy;
    }

    public void restoreEnergy()
    {
        charge = maxEnergy;
    }



}
