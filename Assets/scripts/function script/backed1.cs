using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class backed1 : MonoBehaviour
{
    public Button back;
    public GameObject pers_1_, pers_2_, muve_pers_2_, c, steper;
    private void Start()
    {
        back.onClick.AddListener(desLVL);

    }
    void desLVL()
    {
        setstep1.step = 100;
        moveLVL2.x = 22f;
        moveLVL2.z = 0f;
        pers_2_.SetActive(false);
        muve_pers_2_.SetActive(false);
        c.SetActive(false);
        steper.SetActive(false);
        pers_1_.SetActive(true);
        Gherator_LVL_2_.con = Gherator_LVL_2_.ref2;
        foreach (GameObject i in Gherator_LVL_2_.set) Destroy(i);
    }
}
