using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class getingLVL : MonoBehaviour
{
    public GameObject generit;
    public static Action sas;
    public int minus;
    public int imput;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            skils.energi -= minus; 
            generit.SetActive(true);
            generatorLVL._start = imput;                          
        }
    }
   
}
