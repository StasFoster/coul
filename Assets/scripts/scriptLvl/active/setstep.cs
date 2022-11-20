using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class setstep : MonoBehaviour
{
    public static Action complit;
    public GameObject gameover;

    private void Start()
    {
        moveLVL.check_step += checkstep;
    }
    void checkstep()
    {
        generatorLVL.steper--;
        GetComponent<Text>().text = "Step" + generatorLVL.steper;
        if (generatorLVL.steper < 0)
        {
            gameover.SetActive(true);
            complit.Invoke();
        }

    }
}
