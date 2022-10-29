using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveLVL_1_ : MonoBehaviour
{
    public static byte[,] con1 = GenereiteLVL_1_struct.con;
    public static float x = GenereiteLVL_1_struct.q;
    public static float z = GenereiteLVL_1_struct.w;
    public GameObject player, complite_LVL;
    public static Action steping;
    public static Action get_coul;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            x--;
            if (x >= 0)
            {
               
                if (GenereiteLVL_1_struct.con[(int)x, (int)z] != 0)
                {
                    Debug.Log("x"+x);
                    Debug.Log("z"+z);
                    Vector3 x_up = new Vector3(x, 0f, z);
                    player.transform.position = x_up;
                    steping.Invoke();
                    if (GenereiteLVL_1_struct.con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (GenereiteLVL_1_struct.con[(int)x, (int)z] == 4)
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
            if (x < 11)
            {
                if (GenereiteLVL_1_struct.con[(int)x, (int)z] != 0)
                {
                    Debug.Log("x" + x);
                    Debug.Log("z" + z);
                    Vector3 x_down = new Vector3(x, 0f, z);
                    player.transform.position = x_down;
                    steping.Invoke();
                    if (GenereiteLVL_1_struct.con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (GenereiteLVL_1_struct.con[(int)x, (int)z] == 4)
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
                if (GenereiteLVL_1_struct.con[(int)x, (int)z] != 0)
                {
                    Debug.Log("x" + x);
                    Debug.Log("z" + z);
                    Vector3 z_left = new Vector3(x, 0f, z);
                    player.transform.position = z_left;
                    steping.Invoke();
                    if (GenereiteLVL_1_struct.con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (GenereiteLVL_1_struct.con[(int)x, (int)z] == 4)
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
            if (z < 12)
            {
                if (GenereiteLVL_1_struct.con[(int)x, (int)z] != 0)
                {
                    Debug.Log("x" + x);
                    Debug.Log("z" + z);
                    Vector3 z_rite = new Vector3(x, 0f, z);
                    player.transform.position = z_rite;
                    steping.Invoke();
                    if (GenereiteLVL_1_struct.con[(int)x, (int)z] == 10)
                    {
                        complite_LVL.SetActive(true);
                    }
                    if (GenereiteLVL_1_struct.con[(int)x, (int)z] == 4)
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
