using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class backed : MonoBehaviour
{
    public Button back;
    public GameObject pers_1_, pers_2_, muve_pers_2_, c, steper;
    private void Start()
    {
        back.onClick.AddListener(desLVL);

    }
    void desLVL()
    {
        setstep.step = 21;
        MoveLVL_1_.x = 7f;
        MoveLVL_1_.z = 0f;
        pers_2_.SetActive(false);
        muve_pers_2_.SetActive(false);
        steper.SetActive(false);
      c.SetActive(false);
        pers_1_.SetActive(true);
        GenereiteLVL_1_struct.con = GenereiteLVL_1_struct.ref1;
        foreach (GameObject i in GenereiteLVL_1_struct.set) Destroy(i);
    }
}
