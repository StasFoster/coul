using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class getingLVL2 : MonoBehaviour
{
    public GameObject generit;
    public int energi_minus;
    public static Action sas2;
    private bool F = true;

    private void OnTriggerStay(Collider other)
    {
      //  sas.Invoke();
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (skils.energi >= energi_minus)
            {
                generit.SetActive(true);
                skils.energi -= energi_minus;
                if (F == true)
                {
                    sas2.Invoke();
                    F = false;
                }
                
            }
        }
    }
   
}
