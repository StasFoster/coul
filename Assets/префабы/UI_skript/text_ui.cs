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
        vinos.text = "������������" + skils.vinosslivost;
        ener.text = "�������" + skils.energi;
        coul.text = "�����" + coul_and_money.couls;
        money.text = "������ " + coul_and_money.money;
    }
}
