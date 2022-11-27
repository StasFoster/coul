using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Json;
using System;
[CreateAssetMenu(fileName = "LVL", menuName = "LvLsITFO/NEWLVL")]
public class lvls : ScriptableObject
{ 
    [SerializeField] private Vector3 _startpos;
    [SerializeField] private int _step, _xint, _zint, _key;
    [SerializeField] private float _xstart, _zstart;
    [SerializeField] private string _path;
    public string path => this._path;
    public int key => this._key;
    public int step => this._step;
    public int xint => this._xint;
    public int zint => this._zint;
    public Vector3 startpos => this._startpos;
    public float xstart => this._xstart;
    public float zstart => this._zstart;
}




