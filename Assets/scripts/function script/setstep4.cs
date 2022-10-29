using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setstep4 : MonoBehaviour
{
    public int sttep;
    public static int step = 34;
    public GameObject gameover, off_run4, reset;

    private void Start()
    {
      
        moveLVL4.steping4 += checkstep2;
    }
    void checkstep2()
    {
        step--;
        GetComponent<Text>().text = "Step" + step;
        if (step < 0)
        {
            gameover.SetActive(true);
            off_run4.SetActive(false);
            reset.SetActive(true);

        }

    }
}
