using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Button restsrt;
    public GameObject gameover, gen, move;
    public lvls lvl;

    void Start()
    {
        restsrt.onClick.AddListener(_Restart);
    }
    void _Restart()
    {
        gameover.SetActive(false);
        move.SetActive(false);
        foreach (GameObject i in generatorLVL.set) Destroy(i);
        generatorLVL._start = lvl.key;
        moveLVL.qwe = 1;
    }
  

}
