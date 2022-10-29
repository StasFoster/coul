using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coul1 : MonoBehaviour
{
    public GameObject putt;

    

    
    void Start()
    {
        moveLVL4.get_coul4 += set_coul;
    }
    void set_coul()
    {
        coul_and_money.couls++;
        Destroy(generatorLVL4.set[(int)moveLVL4.x, (int)moveLVL4.z]);
        Instantiate(putt, new Vector3((int)moveLVL4.x, 0f, (int)moveLVL4.z), Quaternion.identity);
        Debug.Log(generatorLVL4.set[(int)moveLVL4.x, (int)moveLVL4.z]);
        generatorLVL4.con[(int)moveLVL4.x, (int)moveLVL4.z] = 1; 
        Debug.Log(generatorLVL4.con[(int)moveLVL4.x, (int)moveLVL4.z]);
    }
}
