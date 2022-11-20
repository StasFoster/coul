using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class LVLCOUL : coul_and_money
{
    public TextMeshProUGUI setcoul;
    public GameObject pol;
    void Start()
    {
        moveLVL._Coul += take_coul;
    }
   
    public void take_coul()
    {
        couls++;
        moveLVL.coninfo[(int)moveLVL.x][(int)moveLVL.z] = 1;
        Destroy(generatorLVL.set[(int)moveLVL.x, (int)moveLVL.z]);
        generatorLVL.set[(int)moveLVL.x, (int)moveLVL.z] = Instantiate(pol, new Vector3(moveLVL.x, 0f, moveLVL.z), Quaternion.identity);
        setcoul.text = "”голь: " + couls.ToString();
    }
}
