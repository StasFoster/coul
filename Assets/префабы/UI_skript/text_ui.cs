using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_ui : MonoBehaviour
{
    public Text iq, vinos, ener, coul, money;
    private void Start()
    {
        iq = GetComponent<Text>();
        vinos = GetComponent<Text>();
        ener = GetComponent<Text>();
        coul = GetComponent<Text>();
        money = GetComponent<Text>();
    }
    private void Update()
    {
        iq.text = "iq" + skils.iQ;
        vinos.text = "Выносливость" + skils.vinosslivost;
        ener.text = "энергия" + skils.energi;
        coul.text = "уголь" + coul_and_money.couls;
        money.text = "монеты " + coul_and_money.money;
    }
}
