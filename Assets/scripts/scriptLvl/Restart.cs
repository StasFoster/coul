using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Button restsrt;
    public GameObject gameover, gen, move;

    void Start()
    {
        restsrt.onClick.AddListener(_Restart);
    }
    void _Restart()
    {
        gameover.SetActive(false);
        move.SetActive(false);
        gen.SetActive(true); 
    }
  

}
