using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class getingLVL : MonoBehaviour
{
    public GameObject generit;
    public int energi_minus;
    public static Action sas;


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (skils.energi >= energi_minus)
            {
                generit.SetActive(true);
                skils.energi -= energi_minus;
                
            }
        }
    }
   
}
