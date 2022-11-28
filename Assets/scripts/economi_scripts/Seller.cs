using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seller : MonoBehaviour
{
    public Button send;
    public int IQ, Money_re, coal_re;
    private void Start()
    {
        send.onClick.AddListener(Send);
    }
    private void Send()
    {
        if(skils.iQ >= IQ)
        {
            coul_and_money.couls -= coal_re;
            coul_and_money.money += Money_re;
        }
    }
}
