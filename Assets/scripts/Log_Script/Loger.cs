using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Loger : MonoBehaviour
{
    private string _workDirectory;
    private Log_Writer _fileWriter;
    private void Awake()
    {
        _workDirectory = $"{Application.persistentDataPath}/Logs";
        if (!Directory.Exists(_workDirectory))
        {
            Directory.CreateDirectory(_workDirectory);
        }
        _fileWriter = new Log_Writer(_workDirectory);
        Application.logMessageReceived += logMassegesin;
    }

    private void logMassegesin(string condition, string stackTrace, LogType type)
    {
        _fileWriter.Write(condition);
    }
    private void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKeyUp(KeyCode.P))
        {
            UnityEditor.EditorUtility.RevealInFinder(_workDirectory);
        }
#endif
    }
}
