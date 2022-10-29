using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class asdsa : MonoBehaviour
{
    public TextMeshProUGUI q;
    void Start()
    {
        
    }
       

    // Update is called once per frame
    void Update()
    {
        STAR();
    }
    public void STAR()
    {
        for (int i = 0; i < 1000; i++)
        {
            q.text = "sasasasasass" + i;
        }
    }
}
