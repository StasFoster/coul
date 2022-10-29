using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class send_coul : MonoBehaviour
{
    public Button send;
    public static Action sending;
    private void Start()
    {
        send.onClick.AddListener(coul_send);
    }
    void coul_send()
    {
        sending.Invoke();
    }
}
