using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI4 : MonoBehaviour
{
    private void FixedUpdate()
    {
        GetComponent<Text>().text = "уголь" + coul_and_money.couls;
    }
}