using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_door1 : MonoBehaviour
{
    public int x;
    public int z;
    public GameObject putt;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(generatorLVL4.set[x, z]);
            Instantiate(putt, new Vector3(x, 0f, z), Quaternion.identity);
            generatorLVL4.con[x, z] = 1;
        }
    }

}
