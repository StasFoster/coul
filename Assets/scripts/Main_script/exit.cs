using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit : MonoBehaviour
{
    public Button sas;
    private void Start()
    {
        sas.onClick.AddListener(Exit_game);
    }
    private void Exit_game()
    {
        Application.Quit();
    }
}
