using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active_step_2 : MonoBehaviour
{
    private void Update()
    {
        GetComponent<setstep1>().enabled = true;
        GetComponent<active_step_2>().enabled = false;
    }
}
