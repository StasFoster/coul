using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sennd : MonoBehaviour
{
    private void Start()
    {
        send_coul.sending += sesend;
    }
    void sesend()
    {
        if(coul_and_money.couls >= seller_list.price_saller_1_)
        {
            coul_and_money.couls -= seller_list.price_saller_1_;
            coul_and_money.money += seller_list.money_saller_1_;
        }
    }
}
