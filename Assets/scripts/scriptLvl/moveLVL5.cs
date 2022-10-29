using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
public class moveLVL5 : MonoBehaviour
{
    public lvls lvlinfo;
    public static byte[,] coninfo;
    public static float x,z;
    public GameObject player, complit_lvl;
    public static Action _Coul;
    public static UnityEvent q;
    private void Awake()
    {
        coninfo = new byte[lvlinfo.xint, lvlinfo.zint];
        int w = 0;
        for (int i = 0; i < lvlinfo.xint; i++)
        {
            for (int j = 0; j < lvlinfo.zint; j++)
            {
                coninfo[i, j] = lvlinfo.struckt[w];
                w++;
            }
        }
    }
    private void Start()
    {
        z = lvlinfo.zstart;
        x = lvlinfo.xstart;
        Debug.Log(x + "__" + z);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            x--;
            if (x >= 0)
            {   
                if (coninfo[(int)x, (int)z] != 0 & coninfo[(int)x, (int)z] != 3)
                {
                    Vector3 x_up = new Vector3(x, 0f, z);
                    player.transform.position = x_up;
                    Debug.Log("_?");
                    if (coninfo[(int)x, (int)z] == 5)
                    {
                        _Coul.Invoke();
                    }
                    if (coninfo[(int)x, (int)z] == 10)
                    {
                        complit_lvl.SetActive(true);
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
                if (coninfo[(int)x, (int)z] != 0 & coninfo[(int)x, (int)z] != 3)
                {
                    Vector3 x_down = new Vector3(x, 0f, z);
                    player.transform.position = x_down;
                    if (coninfo[(int)x, (int)z] == 5)
                    {
                        _Coul.Invoke();
                    }
                    if (coninfo[(int)x, (int)z] == 10)
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
                if (coninfo[(int)x, (int)z] != 0 & coninfo[(int)x, (int)z] != 3)
                {
                    Vector3 z_left = new Vector3(x, 0f, z);
                    player.transform.position = z_left;
                    if (coninfo[(int)x, (int)z] == 5)
                    {
                        _Coul.Invoke();
                    }
                    if (coninfo[(int)x, (int)z] == 10)
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
                if (coninfo[(int)x, (int)z] != 0 & coninfo[(int)x, (int)z] != 3)
                {
                    Vector3 z_rite = new Vector3(x, 0f, z);
                    player.transform.position = z_rite;
                    if (coninfo[(int)x, (int)z] == 5)
                    {
                        _Coul.Invoke();
                    }
                    if (coninfo[(int)x, (int)z] == 10)
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