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
        moveLVL5._Coul += take_coul;
    }
   
    public void take_coul()
    {
        couls++;
        moveLVL5.coninfo[(int)moveLVL5.x, (int)moveLVL5.z] = 1;
        Destroy(generatorLVL5.set[(int)moveLVL5.x, (int)moveLVL5.z]);
        generatorLVL5.set[(int)moveLVL5.x, (int)moveLVL5.z] = Instantiate(pol, new Vector3(moveLVL5.x, 0f, moveLVL5.z), Quaternion.identity);
        setcoul.text = "”голь: " + couls.ToString();
    }
}
