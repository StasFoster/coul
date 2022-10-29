using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tut_move : MonoBehaviour
{
       public GameObject panel, qwe;

private void OnTriggerStay(Collider other)
{
    StartCoroutine(tutor_1());
}
private IEnumerator tutor_1()
{
    panel.SetActive(true);
    yield return new WaitForSeconds(11);
    panel.SetActive(false);
    Destroy(qwe);
}
}
