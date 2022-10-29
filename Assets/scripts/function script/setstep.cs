using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setstep : MonoBehaviour
{
    public int sttep;
    public static int step = 21;
    public GameObject gameover, off_run1, reset;

    private void Start()
    {
        MoveLVL_1_.steping += checkstep;
        reset.SetActive(true);

    }
    void checkstep()
    {
        step--;
        GetComponent<Text>().text = "Step" + step;
        if (step < 0)
        {
            gameover.SetActive(true);
            off_run1.SetActive(false);
            reset.SetActive(true);

        }

    }
}
