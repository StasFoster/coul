using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.IO;

public class Log_Writer
{
    private string _folder;
    private string _filePath;
    private const string DataFormat = "yyyy-MM-dd";
    public Log_Writer(string folder)
    {
        _folder = folder;
        ManagePath();
    }
    private void ManagePath()
    {
        _folder = $"{_folder}/{DateTime.UtcNow.ToString(DataFormat)}.log";
    }
    public void Write(string message)
    {
        using (FileStream fs = File.Open(_filePath, FileMode.Append, FileAccess.Write, FileShare.Read))
        {
            var bytes = Encoding.UTF8.GetBytes(message);
            fs.Write(bytes, 0, bytes.Length);
        }
    }
}
