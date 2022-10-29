using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Json;
using System;
public class set_json : MonoBehaviour
{
    
    private void Start()
    {
        string path = Environment.CurrentDirectory;
        Debug.Log(path);
    }
}
public class Rootobject
{
    public static int[,] t { get; set; }
}