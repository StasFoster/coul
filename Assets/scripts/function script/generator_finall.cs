using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator_finall : MonoBehaviour
{
    public GameObject Stena, Putt, coul, pers_2_, muve_pers_2_, pers_1_, generator, steper, promt_box, fake_lever, fake_set_box, jamp, foll, error_float, door, lever, mhs_box, set_box, box1, box2, box3, box4, box5, box6, box7, box8, box9, box10, box11, box12, box13,box14,box15, box16, box17, box18, box19, box20, box21, box22, box23, box24, box25, box26, box27,box28;
    public static GameObject[,] set = new GameObject[52, 20];
    public static float q2 = 51f;
    public static float w2 = 7f;
    public static Vector3 startpos = new Vector3(51f, 0.5f, 7f);
    public static byte[,] con = new byte[,] { { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 3, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 1, 1, 1, 1, 43, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 7, 31, 3, 6, 0, 0 }, { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 31, 7, 3, 5, 0, 0 }, { 0, 0, 1, 1, 1, 8, 8, 8, 1, 1, 1, 8, 1, 1, 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 2, 1, 1, 1, 1, 2, 1, 1, 31, 7, 3, 11, 0, 0 }, { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 7, 31, 3, 12, 0, 0 }, { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 1, 0, 3, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0, 8, 8, 8, 0, 0, 43, 0, 1, 0, 1, 1, 0, 0 }, { 0, 71, 71, 71, 71, 0, 0, 8, 8, 8, 0, 0, 9, 0, 1, 1, 0, 1, 0, 0 }, { 0, 71, 2, 71, 71, 0, 0, 8, 8, 8, 0, 0, 9, 0, 1, 0, 1, 1, 0, 0 }, { 0, 71, 71, 71, 71, 0, 43, 9, 9, 43, 9, 9, 43, 0, 1, 1, 1, 0, 0, 0 }, { 0, 71, 71, 71, 71, 0, 9, 0, 0, 9, 0, 0, 9, 0, 13, 7, 31, 31, 0, 0 }, { 0, 71, 71, 71, 71, 0, 9, 0, 0, 9, 0, 0, 9, 0, 14, 31, 7, 31, 0, 0 }, { 0, 0, 0, 0, 1, 0, 43, 9, 9, 43, 9, 9, 42, 0, 15, 7, 31, 31, 0, 0 }, { 0, 1, 1, 1, 1, 0, 9, 0, 0, 9, 0, 0, 9, 0, 16, 31, 31, 7, 0, 0 }, { 0, 1, 8, 1, 1, 0, 9, 0, 0, 9, 0, 0, 9, 0, 1, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 0, 43, 9, 9, 43, 9, 9, 42, 0, 1, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 43, 43, 43, 43, 0 }, { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 9, 9, 9, 9, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 0, 7, 17, 1, 18, 7, 0, 9, 9, 9, 9, 0 }, { 0, 1, 1, 1, 8, 1, 1, 1, 0, 7, 19, 1, 20, 7, 0, 43, 43, 43, 43, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 0, 7, 21, 1, 22, 7, 0, 9, 9, 9, 9, 0 }, { 0, 1, 1, 1, 8, 1, 8, 1, 0, 7, 23, 1, 24, 7, 0, 9, 9, 9, 9, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 0, 7, 25, 1, 26, 7, 0, 43, 43, 43, 43, 0 }, { 0, 1, 8, 1, 8, 1, 8, 1, 0, 7, 27, 1, 28, 7, 0, 9, 9, 9, 9, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 0, 7, 29, 1, 30, 7, 0, 9, 9, 9, 9, 0 }, { 0, 1, 8, 1, 8, 1, 8, 1, 0, 7, 32, 1, 33, 7, 0, 43, 43, 43, 43, 0 }, { 0, 1, 2, 1, 2, 1, 2, 1, 0, 7, 34, 1, 36, 7, 0, 9, 9, 9, 9, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 0, 7, 38, 1, 39, 7, 0, 9, 9, 9, 9, 0 }, { 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 43, 43, 43, 43, 0 }, { 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 44, 44, 44, 44, 0 }, { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 44, 44, 44, 44, 0 }, { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 44, 44, 44, 44, 0 }, { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 44, 44, 44, 44, 0 }, { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 44, 44, 44, 44, 0 }, { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
    void FixedUpdate()
    {
        pers_2_.transform.position = startpos;
        Debug.Log("rrr");
        pers_2_.SetActive(true);
        steper.SetActive(true);
        muve_pers_2_.SetActive(true);
        pers_1_.SetActive(false);
        for (float x = 0f; x < 52; x++)
        {
            for (float z = 0f; z < 20; z++)
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
                if (con[(int)x, (int)z] == 9)
                {
                    GameObject s = Instantiate(foll, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 71)
                {
                    GameObject s = Instantiate(fake_lever, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 43)
                {
                    GameObject s = Instantiate(jamp, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 31)
                {
                    GameObject s = Instantiate(fake_set_box, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 6)
                {
                    GameObject s = Instantiate(box1, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 7)
                {
                    GameObject s = Instantiate(set_box, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 44)
                {
                    GameObject s = Instantiate(mhs_box, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 8)
                {
                    GameObject s = Instantiate(promt_box, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 2)
                {
                    GameObject s = Instantiate(lever, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 3)
                {
                    GameObject s = Instantiate(door, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 42)
                {
                    GameObject s = Instantiate(error_float, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 5)
                {
                    GameObject s = Instantiate(box2, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 11)
                {
                    GameObject s = Instantiate(box3, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 12)
                {
                    GameObject s = Instantiate(box4, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 13)
                {
                    GameObject s = Instantiate(box5, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 14)
                {
                    GameObject s = Instantiate(box6, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 15)
                {
                    GameObject s = Instantiate(box7, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 16)
                {
                    GameObject s = Instantiate(box8, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 17)
                {
                    GameObject s = Instantiate(box9, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 18)
                {
                    GameObject s = Instantiate(box10, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 19)
                {
                    GameObject s = Instantiate(box11, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 20)
                {
                    GameObject s = Instantiate(box12, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 21)
                {
                    GameObject s = Instantiate(box13, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 22)
                {
                    GameObject s = Instantiate(box14, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 23)
                {
                    GameObject s = Instantiate(box15, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 24)
                {
                    GameObject s = Instantiate(box16, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 25)
                {
                    GameObject s = Instantiate(box17, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 26)
                {
                    GameObject s = Instantiate(box18, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 27)
                {
                    GameObject s = Instantiate(box19, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 28)
                {
                    GameObject s = Instantiate(box20, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 29)
                {
                    GameObject s = Instantiate(box21, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 30)
                {
                    GameObject s = Instantiate(box22, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 32)
                {
                    GameObject s = Instantiate(box23, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 33)
                {
                    GameObject s = Instantiate(box24, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 34)
                {
                    GameObject s = Instantiate(box25, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 35)
                {
                    GameObject s = Instantiate(box26, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 36)
                {
                    GameObject s = Instantiate(box27, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 37)
                {
                    GameObject s = Instantiate(box28, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 38)
                {
                    GameObject s = Instantiate(box27, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 39)
                {
                    GameObject s = Instantiate(box28, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }


            }
        }
        generator.SetActive(false);
    }
}
