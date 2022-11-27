using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UI5 : MonoBehaviour
{
    int a = 0;
    private void FixedUpdate()
    {
        GetComponent<Text>().text = Convert.ToString(a);
        a += generatorLVL._start;
    }
}

