using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialog2 : MonoBehaviour
{
    public GameObject dialog_, send_light, move
        ;
    private void Start()
    {
        dialog.dio += Curot_dio;
        dialog.sto += active_send;
    }
    void Curot_dio()
    {
        StartCoroutine(ewq());
    }
    void active_send()
    {
        send_light.SetActive(true);
    }
    private IEnumerator ewq()
    {
        dialog_.SetActive(true);
        move.SetActive(false);
        yield return new WaitForSeconds(7);
        dialog_.SetActive(false);
        move.SetActive(true);
    }
}
