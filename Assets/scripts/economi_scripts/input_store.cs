using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input_store : MonoBehaviour
{
    public GameObject seller;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            seller.SetActive(true);
        }
    }
}
