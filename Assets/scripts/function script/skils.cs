using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skils : MonoBehaviour
{
    public static int energi = 1;
    public static int iQ = 1;
    public static int vinosslivost = 1;
    int price_energi = 2; int price_vinoslivost = 1; int price_iQ = 3;
    private void Start()
    {
        buy.plas_energi += up_energi;
        buy.plus_vinoslivost += up_vinoslivost;
        buy.plus_iQ += up_iQ;
    }
    void up_energi()
    {
        if (coul_and_money.money >= price_energi)
        {
            coul_and_money.money -= price_energi;
            referens.v ++;
        }
    }
    void up_vinoslivost()
    {
        if (coul_and_money.money >= price_vinoslivost)
        {
            coul_and_money.money -= price_vinoslivost;
            referens.q++;
        }
    }
    void up_iQ()
    {
        if (coul_and_money.money >= price_iQ)
        {
            coul_and_money.money -= price_iQ;
            iQ++;
        }
    }
}
