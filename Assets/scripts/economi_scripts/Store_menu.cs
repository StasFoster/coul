using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store_menu : skils
{
    public Button buyIQ, buystamina, buyenergi;
    private void Start()
    {
        buyenergi.onClick.AddListener(up_energi);
        buyIQ.onClick.AddListener(up_iQ);
        buystamina.onClick.AddListener(up_stamina);
    }
}
