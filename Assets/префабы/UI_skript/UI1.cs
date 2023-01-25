using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI1 : MonoBehaviour
{
    private void FixedUpdate()
    {
        GetComponent<Text>().text = "энергия" + skils.energi;
    }
}