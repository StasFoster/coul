using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coul_and_money : MonoBehaviour
{
    public static int couls = 10;
    public static int money = 10;
    private void Start()
    {
        send_coul.sending += sennd;
    }
    void sennd() { 
        if (couls >= seller_list.price_saller_1_)
        {
            {
                couls = couls - seller_list.price_saller_1_;
                money += seller_list.money_saller_1_;
                Debug.Log(couls);
                Debug.Log(money);
            }
        }
    }
}
