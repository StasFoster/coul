using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System;
public class generatorLVL : MonoBehaviour
{
    public lvls lvlinfo;
    public static int _x, _z, steper;
    public GameObject _0_, _1_, _2_, _3_, _4_, _5_, _10_, pers_2_, muve_pers_2_, pers_1_, gen;
    public static GameObject[,] set;
    public static int _start = 0;
    public static int[][] con { get; set; }
    public void Update()
    {
        if (_start == lvlinfo.key)
        {
            string path = Environment.CurrentDirectory + "\\Assets\\Data_file\\" + lvlinfo.path;
            StreamReader text = new StreamReader(path);
            string json = text.ReadToEnd();
            Struct_LVL s_l = JsonConvert.DeserializeObject<Struct_LVL>(json);
            steper = lvlinfo.step;
            con = s_l.stuct;
            moveLVL.coninfo = s_l.stuct;
            _x = lvlinfo.xint;
            _z = lvlinfo.zint;
            set = new GameObject[_x, _z];
            pers_2_.transform.position = lvlinfo.startpos;
            pers_2_.SetActive(true);
            muve_pers_2_.SetActive(true);
            pers_1_.SetActive(false);
            moveLVL.qwe = 1;
            Debug.Log("√≈Õ≈–¿“Œ– ¬ Àﬁ◊®Õ");
            for (float x = 0f; x < lvlinfo.xint; x++)
            {
                for (float z = 0f; z < lvlinfo.zint; z++)
                {
                 //s   Debug.Log("1");
                    if (con[(int)x][(int)z] == 1)
                    {
                        GameObject s = Instantiate(_1_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }
                    if (con[(int)x][(int)z] == 0)
                    {
                        GameObject s = Instantiate(_0_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }
                    if (con[(int)x][(int)z] == 5)
                    {
                        GameObject s = Instantiate(_5_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }

                    if (con[(int)x][(int)z] == 2)
                    {
                        GameObject s = Instantiate(_2_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }

                    if (con[(int)x][(int)z] == 3)
                    {
                        GameObject s = Instantiate(_3_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }

                    if (con[(int)x][(int)z] == 4)
                    {
                        GameObject s = Instantiate(_4_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }
                    if (con[(int)x][(int)z] == 10)
                    {
                        GameObject s = Instantiate(_10_, new Vector3(x, 0f, z), Quaternion.identity);
                        set[(int)x, (int)z] = s;
                    }
                }
            }
            _start = 0;
        }
    }
}
public class Struct_LVL
{
    public int[][] stuct { get; set; }
}