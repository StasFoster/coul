using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active_step_1 : MonoBehaviour
{
    private void Update()
    {
        GetComponent<setstep>().enabled = true;
        GetComponent<active_step_1>().enabled = false;
    }
}
