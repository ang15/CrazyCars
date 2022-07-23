using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    [SerializeField]
    private Material material;
    public void left()
    {
        if (material.carChange == 4)
        {
            material.carChange = 0;
        }
        else
        {
            material.carChange++;
        }
        GetComponent<Image>().sprite = material.cars[material.carChange];
    }
    public void Right()
    {
        if (material.carChange == 0)
        {
            material.carChange = 4;
        }
        else
        {
            material.carChange--;
        }
        GetComponent<Image>().sprite = material.cars[material.carChange];
    }

}
