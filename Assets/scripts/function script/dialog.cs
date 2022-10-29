using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class dialog : MonoBehaviour
{
    public static Action dio, sto;

    private void OnTriggerStay(Collider other)
    {
        dio.Invoke();
        sto.Invoke();
    }

}
