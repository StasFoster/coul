using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class triger_final : MonoBehaviour
{
    public static Action seett;
    private void OnTriggerStay(Collider other)
    {
        seett.Invoke();
    }
}
