using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class moveLVL2 : MonoBehaviour
{
    public static byte[,] con = Gherator_LVL_2_.con;
    public static float x = Gherator_LVL_2_.q2;
    public static float z = Gherator_LVL_2_.w2;
    public GameObject player, complite_LVL;
    public static Action steping2;
    public static Action get_coul;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            x--;
            if (x >= 0)
            {

                if (con[(int)x, (int)z] != 0)
                {
                    Vector3 x_up = new Vector3(x, 0f, z);
                    player.transform.position = x_up;
                    steping2.Invoke();
                    if (con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (con[(int)x, (int)z] == 4)
                    {
                        get_coul.Invoke();
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
            if (x <= 21)
            {
                if (con[(int)x, (int)z] != 0)
                {
                    Vector3 x_down = new Vector3(x, 0f, z);
                    player.transform.position = x_down;
                    steping2.Invoke();
                    if (con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (con[(int)x, (int)z] == 4)
                    {
                        get_coul.Invoke();
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
                if (con[(int)x, (int)z] != 0)
                {
                    Vector3 z_left = new Vector3(x, 0f, z);
                    player.transform.position = z_left;
                    steping2.Invoke();
                    if (con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (con[(int)x, (int)z] == 4)
                    {
                        get_coul.Invoke();
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
            if (z < 22)
            {
                if (con[(int)x, (int)z] != 0)
                {
                    Vector3 z_rite = new Vector3(x, 0f, z);
                    player.transform.position = z_rite;
                    steping2.Invoke();
                    if (con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (con[(int)x, (int)z] == 4)
                    {
                        get_coul.Invoke();
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

