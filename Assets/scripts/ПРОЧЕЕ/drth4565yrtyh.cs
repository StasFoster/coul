using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class drth4565yrtyh : MonoBehaviour
{
    public GameObject panrl, pers;
    float vmdf = 0.5f;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Q))
        {
            panrl.transform.position = Vector3.Lerp(panrl.transform.position, pers.transform.position, vmdf);
            Debug.Log("fgrtghtgh");
        }
    }
}
