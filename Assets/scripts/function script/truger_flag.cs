using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class truger_flag : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool F1 = false;
    private void OnTriggerStay(Collider other)
    {
        F1 = true;
    }
}
