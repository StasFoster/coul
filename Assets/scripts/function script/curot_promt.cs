using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curot_promt : MonoBehaviour
{
    public GameObject Habits;
    private void Start()
    {
        getingLVL.sas += sus;
    }
    void sus()
    {
        StartCoroutine(promt());
    }
    private IEnumerator promt()
    {
        Habits.SetActive(true);
        yield return new WaitForSeconds(7);
        Habits.SetActive(false);
    }
}
