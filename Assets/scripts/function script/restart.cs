using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public Button restsrt;
    public GameObject gameover, pers_2_, on_run, reset;

    void Start()
    {

        restsrt.onClick.AddListener(restrter);
    }
    void restrter()
    {
        MoveLVL_1_.x = 7f;
        MoveLVL_1_.z = 0f;
        setstep.step = 21;
        on_run.SetActive(true);
        gameover.SetActive(false);
        GenereiteLVL_1_struct.con = GenereiteLVL_1_struct.ref1;
        pers_2_.transform.position = GenereiteLVL_1_struct.startpos;
        reset.SetActive(false);
    }
  

}
