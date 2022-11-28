using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run_2_ : MonoBehaviour
{
    private Rigidbody player;
    public static float speed = 500f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 Muve = new Vector3(-h, 0f, -v);
        player.velocity = Muve * speed;
    }
}
