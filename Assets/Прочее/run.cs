using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
