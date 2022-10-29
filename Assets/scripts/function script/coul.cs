using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coul : MonoBehaviour
{
    public int x;
    public int z;
    public GameObject putt;

    

    
    void Start()
    {
        MoveLVL_1_.get_coul += set_coul;
    }
    void set_coul()
    {
        coul_and_money.couls++;
        Destroy(GenereiteLVL_1_struct.set[(int)MoveLVL_1_.x, (int)MoveLVL_1_.z]);
        GameObject s = Instantiate(putt, new Vector3((int)MoveLVL_1_.x, 0f, (int)MoveLVL_1_.z), Quaternion.identity);
        GenereiteLVL_1_struct.set[(int)MoveLVL_1_.x, (int)MoveLVL_1_.z] = s;
        MoveLVL_1_.con1[(int)MoveLVL_1_.x, (int)MoveLVL_1_.z] = 1; 
        
    }
}
