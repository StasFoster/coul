using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class setstep : MonoBehaviour
{
    private int step;
    public static Action complit;
    public GameObject gameover;

    private void Start()
    {
        step = generatorLVL.steper;
        moveLVL.check_step += checkstep;
    }
    void checkstep()
    {
        step--;
        GetComponent<Text>().text = "Step" + step;
        if (step < 0)
        {
            gameover.SetActive(true);
            complit.Invoke();
        }

    }
}
