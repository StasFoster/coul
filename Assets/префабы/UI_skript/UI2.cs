using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI2 : MonoBehaviour
{
    private void FixedUpdate()
    {
        GetComponent<Text>().text = "выносливость" + skils.vinosslivost;
    }
}

