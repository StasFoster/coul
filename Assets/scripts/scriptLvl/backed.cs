using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class backed : MonoBehaviour
{
    public Button _back;
    public GameObject _pers_1_, _pers_2_, _muve_pers_2_, gameover;
    void Start()
    {
        _back.onClick.AddListener(_desLVL);

    }
    void _desLVL()
    {
        _pers_2_.SetActive(false);
        _muve_pers_2_.SetActive(false);
        _pers_1_.SetActive(true);
        gameover.SetActive(false);
        foreach (GameObject i in generatorLVL.set) Destroy(i);
    }
}
