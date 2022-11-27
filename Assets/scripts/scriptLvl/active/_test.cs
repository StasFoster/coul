using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _test : MonoBehaviour
{
    public Button s;
    private void Start()
    {
        s.onClick.AddListener(gen);
    }
    public void gen()
    {
        generatorLVL._start = 1;
    }
}
