using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class backed7 : MonoBehaviour
{
    public Button back;
    public GameObject pers_1_, pers_2_, muve_pers_2_, c, steper;
    private void Start()
    {
        back.onClick.AddListener(desLVL);

    }
    void desLVL()
    {
        setstep7.step = 100;
        moveLVL7.x = 0f;
        moveLVL7.z = 5f;
        pers_2_.SetActive(false);
        muve_pers_2_.SetActive(false);
        c.SetActive(false);
        steper.SetActive(false);
        pers_1_.SetActive(true);
        generatorLVL7.con = generatorLVL7.ref7;
        foreach (GameObject i in generatorLVL7.set) Destroy(i);
    }
}
