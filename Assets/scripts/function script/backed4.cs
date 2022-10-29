using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class backed4 : MonoBehaviour
{
    public Button back;
    public GameObject pers_1_, pers_2_, muve_pers_2_, c, steper;
    private void Start()
    {
        back.onClick.AddListener(desLVL);

    }
    void desLVL()
    {
        setstep4.step = 100;
        moveLVL4.x = 8f;
        moveLVL4.z = 0f;
        pers_2_.SetActive(false);
        muve_pers_2_.SetActive(false);
        c.SetActive(false);
        steper.SetActive(false);
        pers_1_.SetActive(true);
        generatorLVL4.con = generatorLVL4.ref4;
        foreach (GameObject i in generatorLVL4.set) Destroy(i);
    }
}
