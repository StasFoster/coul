using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class in_store : MonoBehaviour
{
    public GameObject Habits, store;
    public GameObject referens;
    private void OnTriggerStay(Collider other)
    {
        StartCoroutine(promt());
        if (Input.GetKeyDown(KeyCode.E))
        {
            store.SetActive(true);
            referens.SetActive(true);
        }
    }
    private IEnumerator promt()
    {
        Habits.SetActive(true);
        yield return new WaitForSeconds(7);
        Habits.SetActive(false);
    }
}
