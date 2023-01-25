using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private void FixedUpdate()
    {
        GetComponent<Text>().text = "iq" + skils.iQ; 
    }
}
