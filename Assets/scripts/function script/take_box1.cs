using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class take_box1 : MonoBehaviour
{
    private GameObject  q, pers;
    
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            GameObject.FindGameObjectWithTag("box3").transform.position = Vector3.Lerp(GameObject.FindGameObjectWithTag("box3").transform.position, GameObject.FindGameObjectWithTag("box").transform.position,0.99f);
           
        }
    }
}
