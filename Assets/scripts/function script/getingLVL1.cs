using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class getingLVL1 : MonoBehaviour
{
    public GameObject generit;
    public int energi_minus;
    public static Action sas1;
    private bool F = true;

    private void OnTriggerStay(Collider other)
    {
      //  sas1.Invoke();
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (skils.energi >= energi_minus)
            {
                generit.SetActive(true);
                skils.energi -= energi_minus;
                if (F == true)
                {
                 sas1.Invoke();
                    F = false;
                }
                
            }
        }
        
    }
   
}
