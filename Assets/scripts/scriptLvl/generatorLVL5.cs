using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class generatorLVL5 : MonoBehaviour
{
    public lvls lvlinfo;
    static int _x, _z;
    public GameObject _0_, _1_, _2_, _3_, _4_ , _5_, _10_, pers_2_, muve_pers_2_, pers_1_, steper;
    public static GameObject[,] set;
    public void Awake()
    {
        _x = lvlinfo.xint;
        _z = lvlinfo.zint;
        set = new GameObject[_x, _z];
        int w = 0;
        pers_2_.transform.position = lvlinfo.startpos;
        pers_2_.SetActive(true);
        steper.SetActive(true);
        muve_pers_2_.SetActive(true);
        pers_1_.SetActive(false);

        
            for (float x = 0f; x < lvlinfo.xint; x++)
            {
                for (float z = 0f; z < lvlinfo.zint; z++)
                {
                    if (lvlinfo.struckt[w] == 1)
                    {
                        GameObject s = Instantiate(_1_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }
                    if (lvlinfo.struckt[w] == 0)
                    {
                        GameObject s = Instantiate(_0_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }
                    if (lvlinfo.struckt[w] == 5)
                    {
                        GameObject s = Instantiate(_5_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }

                    if (lvlinfo.struckt[w] == 2)
                    {
                        GameObject s = Instantiate(_2_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }

                    if (lvlinfo.struckt[w] == 3)
                    {
                        GameObject s = Instantiate(_3_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }

                    if (lvlinfo.struckt[w] == 4)
                    {
                        GameObject s = Instantiate(_4_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }
                    if (lvlinfo.struckt[w] == 10)
                    {
                        GameObject s = Instantiate(_10_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }
                w++;
                }
            }
        
    }
}