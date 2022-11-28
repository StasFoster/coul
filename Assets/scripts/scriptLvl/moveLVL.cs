using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
public class moveLVL : MonoBehaviour
{
    public lvls lvlinfo;
    public static int[][] coninfo;
    public static float x,z;
    public static float qwe = 0;
    public GameObject player, complit_lvl;
    public static Action _Coul, check_step, _complit;
    public static UnityEvent q;
    void Update()
    {
        if(qwe == 1)
        {
            x = lvlinfo.xstart;
            z = lvlinfo.zstart;
            qwe = 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            x--;
            if (x >= 0)
            {
                Debug.Log(x + "__" + z);
                if (coninfo[(int)x][(int)z] != 0 & coninfo[(int)x][(int)z] != 3)
                {
                    Vector3 x_up = new Vector3(x, 0f, z);
                    player.transform.position = x_up;
                    check_step.Invoke();
                    if (coninfo[(int)x][(int)z] == 2)
                    {
                        _Coul.Invoke();
                    }
                    if (coninfo[(int)x][(int)z] == 10)
                    {
                        complit_lvl.SetActive(true);
                        _complit.Invoke();
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
            if (x < lvlinfo.xint) 
            {
                Debug.Log(x + "__" + z);
                if (coninfo[(int)x][(int)z] != 0 & coninfo[(int)x][(int)z] != 3)
                {
                    Vector3 x_down = new Vector3(x, 0f, z);
                    player.transform.position = x_down;
                    check_step.Invoke();
                    if (coninfo[(int)x][(int)z] == 2)
                    {
                        _Coul.Invoke();
                    }
                    if (coninfo[(int)x][(int)z] == 10)
                    {
                        complit_lvl.SetActive(true);
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
                Debug.Log(x + "__" + z);
                if (coninfo[(int)x][(int)z] != 0 & coninfo[(int)x][(int)z] != 3)
                {
                    Vector3 z_left = new Vector3(x, 0f, z);
                    player.transform.position = z_left;
                    check_step.Invoke();
                    if (coninfo[(int)x][(int)z] == 2)
                    {
                        _Coul.Invoke();
                    }
                    if (coninfo[(int)x][(int)z] == 10)
                    {
                        complit_lvl.SetActive(true);
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
            if (z < lvlinfo.zint)
            {
                Debug.Log(x + "__" + z);
                if (coninfo[(int)x][(int)z] != 0 & coninfo[(int)x][(int)z] != 3)
                {
                    Vector3 z_rite = new Vector3(x, 0f, z);
                    player.transform.position = z_rite;
                    check_step.Invoke();
                    if (coninfo[(int)x][(int)z] == 2)
                    {
                        _Coul.Invoke();
                    }
                    if (coninfo[(int)x][(int)z] == 10)
                    {
                        complit_lvl.SetActive(true);
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