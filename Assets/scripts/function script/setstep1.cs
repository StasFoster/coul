using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setstep1 : MonoBehaviour
{
    
    public static int step = 77;
    public GameObject gameover, off_run1,reset;

    private void Start()
    {
      
        moveLVL2.steping2 += checkstep2;
    }
    void checkstep2()
    {
        step--;
        Debug.Log(step);
        GetComponent<Text>().text = "ируш :" + step;
        if (step < 0)
        {
            gameover.SetActive(true);
            off_run1.SetActive(false);
            reset.SetActive(true);

        }

    }
}
