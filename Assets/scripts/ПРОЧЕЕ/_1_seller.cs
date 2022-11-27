using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _1_seller : MonoBehaviour
{
    public GameObject Habits, seller;
    private void OnTriggerStay(Collider other)
    {
        StartCoroutine(promt());
        if (Input.GetKeyDown(KeyCode.E))
        {
            seller.SetActive(true);
        }
    }
    private IEnumerator promt()
    {
        Habits.SetActive(true);
        yield return new WaitForSeconds(7);
        Habits.SetActive(false);
    }
}
