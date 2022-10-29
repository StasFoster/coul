using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reskils : MonoBehaviour
{
    public GameObject promt;
    public static bool F;
    private void OnTriggerStay(Collider other)
    {
        StartCoroutine(promt_());
        if (Input.GetKeyDown(KeyCode.E))
        {
            F = true;
            skils.energi = referens.v;
            skils.vinosslivost = referens.q;
        }
    }
    private IEnumerator promt_()
    {
        promt.SetActive(true);
        yield return new WaitForSeconds(7);
        promt.SetActive(false);
    }
}
