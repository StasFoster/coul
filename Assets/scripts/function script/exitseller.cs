using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitseller : MonoBehaviour
{
    public Button exit;
    public GameObject panel;

    private void Start()
    {
        exit.onClick.AddListener(_exit_);
    }
    void _exit_()
    {
        panel.SetActive(false);
    }
}
