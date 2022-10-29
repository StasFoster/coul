using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triger_flag_2 : MonoBehaviour
{
    public static bool F2 = false;
    private void OnTriggerStay(Collider other)
    {
        F2 = true;
    }
}
