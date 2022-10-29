using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenereiteLVL_1_struct : MonoBehaviour
{
    public GameObject Stena, Putt, coul, pers_2_, pers_1_, muve_pers_2_,generator,strper;
    public static float q = 7f;
    public static float w = 0f;
    public static Vector3 startpos = new Vector3(7f, 0.5f, 0f);
    public static GameObject[,] set = new GameObject[11, 12];
    public static byte[,] con = new byte[,] { { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0 }, { 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 1 }, { 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1 }, { 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 10 }, { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 1 }, { 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0 }, { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0 }, { 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 4, 1, 1, 1, 0, 0, 0, 0, 0 } };
    public static byte[,] ref1 = new byte[,] { { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0 }, { 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 1 }, { 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1 }, { 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 10 }, { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 1 }, { 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0 }, { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0 }, { 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 4, 1, 1, 1, 0, 0, 0, 0, 0 } };
    void FixedUpdate()
    {
       pers_2_.transform.position = startpos;
       pers_2_.SetActive(true);
        muve_pers_2_.SetActive(true);
        strper.SetActive(true);
       pers_1_.SetActive(false);
       for(float x = 0f; x < 11; x++)
        {
            for (float z = 0f; z < 12; z++)
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
            }
        }
        generator.SetActive(false);
    }
}
