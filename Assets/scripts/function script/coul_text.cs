using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coul_text : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Text>().text = "coul" + coul_and_money.couls;
    }
}
