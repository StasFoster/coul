using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    public int speeed = 100;
    public int speeed2 = 500;
    private void Update()
    {
        if (skils.vinosslivost == 0)
        {
            run_2_.speed = speeed;
        }
        else { run_2_.speed = speeed2; }
    }
}
