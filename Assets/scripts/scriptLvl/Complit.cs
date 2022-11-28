using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Complit : MonoBehaviour
{
    public GameObject Move, gameov;
    private void Start()
    {
        moveLVL._complit += stop;
        moveLVL._Fall += Over;
        setstep.complit += stop_2;
    }
    void stop()
    {
        Move.SetActive(false);
        gameov.SetActive(false);
    }
    void stop_2()
    {
        Move.SetActive(false);
    }
    void Over()
    {
        gameov.SetActive(true);
        Move.SetActive(false);
    }
}
