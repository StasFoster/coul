using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit_store : MonoBehaviour
{
    public Button exit;
    public GameObject panel_store, referens;
    private void Start()
    {
        exit.onClick.AddListener(clous);
    }
    void clous()
    {
        panel_store.SetActive(false);
        referens.SetActive(false);
    }
}
