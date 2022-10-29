using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI3 : MonoBehaviour
{
    private void FixedUpdate()
    {
        GetComponent<Text>().text = "деньги" + coul_and_money.money;
    }
}