using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minusvinoslivost : MonoBehaviour
{
    private void Start()
    {
      //  StartCoroutine(Vinoslivostminus());
    }


    private IEnumerator Vinoslivostminus()
    {
        while (true)
        {
            if (skils.vinosslivost != 0)
            {
                
                yield return new WaitForSeconds(20);
                skils.vinosslivost--;
            }
            else
            {
                yield return new WaitForSeconds(40);
            }


        }
    }
}

