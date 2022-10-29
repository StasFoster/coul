using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class referens_active : MonoBehaviour
{
    private void Start()
    {
        GetComponent<referens>().enabled = true;
    }
}
