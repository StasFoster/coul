using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tut_piay : MonoBehaviour
{
    public GameObject panel, qwe;

    private void Start()
    {
        set_act.set1 += S;
    }

    void S()
    {
        StartCoroutine(tutor_1());
    }





    private IEnumerator tutor_1()
    {
        panel.SetActive(true);
        yield return new WaitForSeconds(4);
        panel.SetActive(false);
        Destroy(qwe);
    }
}
