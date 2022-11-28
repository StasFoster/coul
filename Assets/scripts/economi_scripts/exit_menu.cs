using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit_menu : MonoBehaviour
{
    public Button exit;
    public GameObject menu;
    private void Start()
    {
        exit.onClick.AddListener(Exit_);
    }
    private void Exit_()
    {
        menu.SetActive(false);
    }
}
