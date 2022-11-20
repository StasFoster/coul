using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Complit : MonoBehaviour
{
    public GameObject Move;
    private void Start()
    {
        moveLVL._complit += stop;
        setstep.complit += stop_2;
    }
    void stop()
    {
        Move.SetActive(false);
    }
    void stop_2()
    {
        Move.SetActive(false);
    }
}
