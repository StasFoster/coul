using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tut_piay1 : MonoBehaviour
{
    public GameObject panel, qwe;
    private void Start()
    {
        set_act1.set2 += S;
    }

    void S()
    {
        StartCoroutine(tutor_1());
    }






    private IEnumerator tutor_1()
    {
        panel.SetActive(true);
        yield return new WaitForSeconds(7);
        panel.SetActive(false);
        Destroy(qwe);
    }
}
