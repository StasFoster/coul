using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop_step_1 : MonoBehaviour
{
    private void Update()
    {
        GetComponent<setstep>().enabled = false;
        GetComponent<stop_step_1>().enabled = false;
    }
}
