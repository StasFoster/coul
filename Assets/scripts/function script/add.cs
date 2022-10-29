using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add : MonoBehaviour
{
    public static GameObject a;
    void Start()
    {
        a = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)){
            Debug.Log("123");
        }
    }
}
