using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
[CreateAssetMenu(fileName = "LVL", menuName = "LvLsITFO/NEWLVL")]

public class lvls : ScriptableObject
{
    [SerializeField] private List<byte> _struckt = new List<byte> { };
    [SerializeField] public Vector3 _startpos;
    [SerializeField] public int _step, _xint, _zint;
    [SerializeField] public float _xstart, _zstart;
    public static byte[,] construct;
   
    public List<byte> struckt => this._struckt;
    public int step => this._step;
    public int xint => this._xint;
    public int zint => this._zint;
    public Vector3 startpos => this._startpos;
    public float xstart => this._xstart;
    public float zstart => this._zstart;
    
    
    
}


