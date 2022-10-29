using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set_final : MonoBehaviour
{
    public GameObject st_final;
    void Start()
    {

        triger_final.seett += generator;
       
    }

    void generator()
    {
        Debug.Log("12321");
        foreach (GameObject i in generatorLVL7.set)
        {
            Destroy(i);
        }
        st_final.SetActive(true);
    }

}
