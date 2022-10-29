using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class generatorLVL7 : MonoBehaviour
{


    public GameObject Stena, Putt, coul, pers_2_, muve_pers_2_, pers_1_, generator, steper, promt, lever_arm, door, box, box2, box3, inf_light, final;
        
    public static GameObject[,] set = new GameObject[10, 11];
    public static float q = 0f;
    public static float w = 5f;
    public static Vector3 startpos = new Vector3(0f, 0.5f, 5f);
    public static byte[,] con = new byte[,] { {0,0,0,0,0,1,0,0,0,0,0 },{0,0,0,1,1,1,1,1,0,0,0 },{0,1,0,1,0,1,0,1,0,1,0 } ,{0,1,0,1,0,1,0,1,0,1,0 } ,{0,6,1,1,0,4,0,1,1,61,0 },{0,1,0,0,0,1,0,0,0,1,0 },{ 0,1,1,7,4,1,4,7,1,1,0 } ,{0,0,0,0,0,3,0,0,0,0,0 },{ 0,0,1,1,1,50,0,0,0,0,0},{0,0,80,0,0,10,0,0,0,0,0 } };
    public static byte[,] ref7 = new byte[,] { { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 }, { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 6, 1, 1, 0, 4, 0, 1, 1, 61, 0 }, { 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0 }, { 0, 1, 1, 7, 4, 1, 4, 7, 1, 1, 0 }, { 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 50, 0, 0, 0, 0, 0 }, { 0, 0, 80, 0, 0, 10, 0, 0, 0, 0, 0 } };
    void FixedUpdate()
    {
        pers_2_.transform.position = startpos;
        setstep7.step = 100;
        pers_2_.SetActive(true);
        steper.SetActive(true);
        muve_pers_2_.SetActive(true);
        pers_1_.SetActive(false);
        for (float x = 0f; x < 10; x++)
        {
            for (float z = 0f; z < 11; z++)
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
                if (con[(int)x, (int)z] == 50)
                {
                    GameObject s = Instantiate(Putt, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 6)
                {
                    GameObject s = Instantiate(box, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 61)
                {
                    GameObject s = Instantiate(box2, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 7)
                {
                    GameObject s = Instantiate(box3, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }
                if (con[(int)x, (int)z] == 80)
                {
                    GameObject s = Instantiate(final, new Vector3(x, 0f, z), Quaternion.identity);
                    set[(int)x, (int)z] = s;
                }




            }
        }
        generator.SetActive(false);
    }
}


