using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coul7 : MonoBehaviour
{
    public GameObject putt;

    

    
    void Start()
    {
        moveLVL7.get_coul7 += set_coul;
    }
    void set_coul()
    {
        coul_and_money.couls++;
        Destroy(generatorLVL7.set[(int)moveLVL7.x, (int)moveLVL7.z]);
        Instantiate(putt, new Vector3((int)moveLVL7.x, 0f, (int)moveLVL7.z), Quaternion.identity);
        Debug.Log(generatorLVL7.set[(int)moveLVL7.x, (int)moveLVL7.z]);
        generatorLVL7.con[(int)moveLVL7.x, (int)moveLVL7.z] = 1; 
        Debug.Log(generatorLVL7.con[(int)moveLVL7.x, (int)moveLVL7.z]);
    }
}
