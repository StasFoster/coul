using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_door_box : MonoBehaviour
{

    public int x, z;
    public GameObject putt;
    private void Update()
    {
        if (truger_flag.F1== true & triger_flag_2.F2 == true)
        {
            Destroy(generatorLVL.set[x, z]);
            Instantiate(putt, new Vector3(x, 0f, z), Quaternion.identity);
         //   generatorLVL.con[x, z] = 1;
        }
    }
}
