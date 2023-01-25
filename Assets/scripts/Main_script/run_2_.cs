using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class run_2_ : MonoBehaviour
{
    private Rigidbody player;
    public Transform Rot_player;
    public static float speed = 500f;
    float a;
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            Rot_player.transform.rotation = Quaternion.Lerp(Rot_player.transform.rotation, Quaternion.Euler(0f, 180f, 0f), 0.15f);
        }
        if (Input.GetKey(KeyCode.S))
        {                            
            Rot_player.transform.rotation = Quaternion.Lerp(Rot_player.transform.rotation, Quaternion.Euler(0f,0f,0f), 0.15f);            
        }
        if (Input.GetKey(KeyCode.D))
        {
            Rot_player.transform.rotation = Quaternion.Lerp(Rot_player.transform.rotation, Quaternion.Euler(0f, -90f, 0f), 0.15f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Rot_player.transform.rotation = Quaternion.Lerp(Rot_player.transform.rotation, Quaternion.Euler(0f, 90f, 0f), 0.15f);
        }
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 Muve = new Vector3(-h, 0f, -v);
        player.velocity = Muve * speed;
    }
}