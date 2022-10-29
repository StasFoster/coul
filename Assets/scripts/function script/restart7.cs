using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart7 : MonoBehaviour
{
    public Button restsrt;
    public GameObject gameover, pers_2_, on_run,reset;

    void Start()
    {

        restsrt.onClick.AddListener(restrter);
    }
    void restrter()
    {
        moveLVL7.x = 8f;
        moveLVL7.z = 0f;
        setstep7.step = 100;
        on_run.SetActive(true);
        gameover.SetActive(false);
        generatorLVL7.con = generatorLVL7.ref7;
        pers_2_.transform.position = generatorLVL7.startpos;
        reset.SetActive(false);
    }
  

}
