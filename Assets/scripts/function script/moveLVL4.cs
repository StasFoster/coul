using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class moveLVL4 : MonoBehaviour
{
    public byte[,] con = generatorLVL4.con;
    public static float x = generatorLVL4.q;
    public static float z = generatorLVL4.w;
    public GameObject player, complite_LVL, lever_arm, lever_arm_2_;
    public static Action steping4;
    public static Action get_coul4;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            x--;
            if (x >= 0)
            {

                if (con[(int)x, (int)z] != 0 & con[(int)x, (int)z] != 5 & con[(int)x, (int)z] != 3)
                {
                    Vector3 x_up = new Vector3(x, 0f, z);
                    player.transform.position = x_up;
                    steping4.Invoke();
                    if (con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (con[(int)x, (int)z] == 4){ get_coul4.Invoke(); }
                    if (con[(int)x, (int)z] == 2)
                    {
                        lever_arm.SetActive(true);
                    }
                    else 
                    { 
                        lever_arm.SetActive(false);
                    }


                }
                else
                {
                    x++;
                }
            }
            else
            {
                x++;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            x++;
            if (x < 12)
            {

                if (con[(int)x, (int)z] != 0 & con[(int)x, (int)z] != 5 & con[(int)x, (int)z] != 3)

                {
                    Vector3 x_down = new Vector3(x, 0f, z);
                    player.transform.position = x_down;
                    steping4.Invoke();
                    if (con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (con[(int)x, (int)z] == 4)
                    {
                        get_coul4.Invoke();
                    }
                    if (con[(int)x, (int)z] == 2) {
                        lever_arm.SetActive(true);
                    }
                    else {
                        lever_arm.SetActive(false);
                    }
                    if (con[(int)x, (int)z] == 12)
                    {
                        lever_arm_2_.SetActive(true);
                    }
                    else
                    {
                        lever_arm_2_.SetActive(false);
                    }
                }
                else
                {
                    x--;
                }
            }
            else
            {
                x--;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            z--;
            if (z >= 0)
            {

                if (con[(int)x, (int)z] != 0 & con[(int)x, (int)z] != 5 & con[(int)x, (int)z] != 3)

                {
                    Vector3 z_left = new Vector3(x, 0f, z);
                    player.transform.position = z_left;
                    steping4.Invoke();
                    if (con[(int)x, (int)z] == 10)
                    if (con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (con[(int)x, (int)z] == 4)
                    {
                        get_coul4.Invoke();
                    }
                    if (con[(int)x, (int)z] == 2) {
                        lever_arm.SetActive(true);
                    }
                    else { 
                        lever_arm.SetActive(false);
                    }
                    if (con[(int)x, (int)z] == 12)
                    {
                        lever_arm_2_.SetActive(true);
                    }
                    else
                    {
                        lever_arm_2_.SetActive(false);
                    }
                }
                else
                {
                    z++;
                }
            }
            else
            {
                z++;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            z++;
            if (z < 13)
            {

                if (con[(int)x, (int)z] != 0 & con[(int)x, (int)z] != 5 & con[(int)x, (int)z] != 3)

                {
                    Vector3 z_rite = new Vector3(x, 0f, z);
                    player.transform.position = z_rite;
                    steping4.Invoke();
                    if (con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (con[(int)x, (int)z] == 4)
                    {
                        get_coul4.Invoke();
                    }
                    if (con[(int)x, (int)z] == 2) {
                        lever_arm.SetActive(true); 
                    }
                    else {
                        lever_arm.SetActive(false);
                    }
                    if (con[(int)x, (int)z] == 12)
                    {
                        lever_arm_2_.SetActive(true);
                    }
                    else
                    {
                        lever_arm_2_.SetActive(false);
                    }
                }
                else
                {
                    z--;
                }
            }
            else
            {
                z--;
            }
        }
    }

}
