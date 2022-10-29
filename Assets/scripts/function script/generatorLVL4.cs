using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class generatorLVL4 : MonoBehaviour
{


    public GameObject Stena, Putt, coul, pers_2_, muve_pers_2_, pers_1_, generator, steper, promt, lever_arm, door;
    public static GameObject[,] set = new GameObject[12, 13];
    public static float q = 8f;
    public static float w = 0f;
    public static Vector3 startpos = new Vector3(8f, 0.5f, 0f);
    public static byte[,] con = new byte[,] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0 }, { 0, 1, 0, 1, 1, 1, 0, 4, 0, 1, 0, 0, 0 }, { 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 3, 1, 10 }, { 0, 0, 4, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 21, 0, 0 }, { 0, 0, 1, 0, 2, 0, 1, 3, 4, 1, 1, 12, 5 }, { 1, 1, 1, 1, 1, 0, 1, 0, 0, 1, 21, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
    public static byte[,] ref4 = new byte[,] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0 }, { 0, 1, 0, 1, 1, 1, 0, 4, 0, 1, 0, 0, 0 }, { 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 3, 1, 10 }, { 0, 0, 4, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 21, 0, 0 }, { 0, 0, 1, 0, 2, 0, 1, 3, 4, 1, 1, 12, 5 }, { 1, 1, 1, 1, 1, 0, 1, 0, 0, 1, 21, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
    void FixedUpdate()
    {
        pers_2_.transform.position = startpos;
        setstep4.step = 34;
        pers_2_.SetActive(true);
        steper.SetActive(true);
        muve_pers_2_.SetActive(true);
        pers_1_.SetActive(false);
        for (float x = 0f; x < 11; x++)
        {
            for (float z = 0f; z < 13; z++)
            {
                if (con[(int)x, (int)z] == 1)
                {
                    GameObject s = Instantiate(Putt, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 0)
                {
                    GameObject s = Instantiate(Stena, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 10)
                {
                    GameObject s = Instantiate(Putt, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 4)
                {
                    GameObject s = Instantiate(coul, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }

                if (con[(int)x, (int)z] == 2)
                {
                    GameObject s = Instantiate(lever_arm, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }

                if (con[(int)x, (int)z] == 3)
                {
                    GameObject s = Instantiate(door, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }

                if (con[(int)x, (int)z] == 5)
                {
                    GameObject s = Instantiate(promt, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 21)
                {
                    GameObject s = Instantiate(lever_arm, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 12)
                {
                    GameObject s = Instantiate(lever_arm, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }



            }
        }
        generator.SetActive(false);
    }
}


