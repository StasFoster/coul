using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class store_light : MonoBehaviour
{
    public Button send;
    public GameObject inf_light;
    private void Start()
    {
        send.onClick.AddListener(light_send);
    }
    void light_send() 
    {
        inf_light.SetActive(true);
    }
}
