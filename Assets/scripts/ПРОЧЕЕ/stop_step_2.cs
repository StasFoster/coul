using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop_step_2 : MonoBehaviour
{
    private void Update()
    {
        GetComponent<setstep1>().enabled = false;
        GetComponent<stop_step_2>().enabled = false;
    }
}
