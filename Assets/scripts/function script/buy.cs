using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class buy : MonoBehaviour
{
    public static Action plas_energi, plus_vinoslivost, plus_iQ;
    public Button buyenergi, buyvinoslivost, buyiQ;
    private void Start()
    {
        buyenergi.onClick.AddListener(add_energi);
        buyvinoslivost.onClick.AddListener(add_vinoslivost);
        buyiQ.onClick.AddListener(add_iQ);
    }
    void add_energi() { plas_energi.Invoke();}
    void add_vinoslivost() { plus_vinoslivost.Invoke(); }
    void add_iQ() { plus_iQ.Invoke(); }
}
