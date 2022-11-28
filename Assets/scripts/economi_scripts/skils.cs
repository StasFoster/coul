using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skils : MonoBehaviour
{
    public static int energi = 1;
    public static int iQ = 1;
    public static int vinosslivost = 1;
    int price_energi = 2; int price_stamina = 1; int price_iQ = 3;
    public void up_energi()
    {
        if (coul_and_money.money >= price_energi)
        {
            coul_and_money.money -= price_energi;
            referens.v ++;
        }
    }
    public void up_stamina()
    {
        if (coul_and_money.money >= price_stamina)
        {
            coul_and_money.money -= price_stamina;
            referens.q++;
        }
    }
    public void up_iQ()
    {
        if (coul_and_money.money >= price_iQ)
        {
            coul_and_money.money -= price_iQ;
            iQ++;
        }
    }
}
