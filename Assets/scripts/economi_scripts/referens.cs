using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class referens : MonoBehaviour
{
    public static int v, q;

    private void Update()
    {
        v = skils.energi;
        q = skils.vinosslivost;
        GetComponent<referens>().enabled = false;
    }

}
