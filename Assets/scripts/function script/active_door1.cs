using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active_door1 : MonoBehaviour
{
    private void Start()
    {
        GetComponent<open_door>().enabled = true;
    }
}
