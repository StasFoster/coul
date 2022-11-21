using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class getingLVL : MonoBehaviour
{
    public GameObject generit;
    public int energi_minus;
    public static Action sas;
    public string imput;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
          
          
                generit.SetActive(true);
                skils.energi -= energi_minus;
                generatorLVL._start = imput;
                
           
        }
    }
   
}
