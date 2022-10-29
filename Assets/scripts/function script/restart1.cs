using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart1 : MonoBehaviour
{
    public Button restsrt;
    public GameObject gameover, pers_2_, on_run, reset;

    void Start()
    {

        restsrt.onClick.AddListener(restrter);
    }
    void restrter()
    {
        moveLVL2.x = 22f;
        moveLVL2.z = 0f;
        setstep1.step = 77;
        on_run.SetActive(true);
        gameover.SetActive(false);
        Gherator_LVL_2_.con = Gherator_LVL_2_.ref2;
        pers_2_.transform.position = Gherator_LVL_2_.startpos;
        reset.SetActive(false);
    }
  

}
