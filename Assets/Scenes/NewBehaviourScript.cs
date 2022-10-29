using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public lvls lvlintfo;
    public static byte[,] coninfo = new byte[8, 13];
    public int w = 0;
    private void Awake()
    {
        for (int x = 0; x < 8; x++)
        {
            for (int z = 0; z < 13; z++)
            {
                coninfo[x, z] = lvlintfo.struckt[w];
                w++;
                Debug.Log("x" + lvlintfo.struckt[w] + "___" + w);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            for(int j = 0; j<13; j++)
            {
                Debug.Log(coninfo[i, j]);
            }
        }
    }
}
