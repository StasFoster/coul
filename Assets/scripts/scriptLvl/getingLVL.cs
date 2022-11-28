using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class getingLVL : MonoBehaviour
{
    public GameObject generit;
    public static Action sas;
    public int minus;
    public int input;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (skils.energi >= minus)
            {
                generit.SetActive(true);
                generatorLVL._start = input;
                skils.energi -= minus;
            }
        }
    }
   
}
