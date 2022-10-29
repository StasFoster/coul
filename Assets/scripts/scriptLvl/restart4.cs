using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart5 : MonoBehaviour
{
    public Button restsrt;
    public GameObject gameover, pers_2_, on_run,resets;

    void Start()
    {

        restsrt.onClick.AddListener(restrter);
    }
    void restrter()
    {
        moveLVL4.x = 8f;
        moveLVL4.z = 0f;
        setstep4.step = 34;
        on_run.SetActive(true);
        gameover.SetActive(false);
        generatorLVL4.con = generatorLVL4.ref4;
        pers_2_.transform.position = generatorLVL4.startpos;
        resets.SetActive(false);
    }
  

}
