using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Zork;
using TMPro;

public class UnityOutputService : MonoBehaviour , IOutputService
{
    [SerializeField]
    private int MaxEntries = 60;
    [SerializeField]
    private Transform OutputTextContainer;
    [SerializeField]
    private Image NewLinePrefab;
    public UnityOutputService() => Entries = new List<GameObject>();
    public void Clear()
    {
        Entries.ForEach(entry => Destroy(entry));
    }

    public void Write(string value)
    {
        ParseAndWriteLine(value);
    }

    public void Write(object value)
    {
        Write(value.ToString());
    }

    public void WriteLine(string value)
    {
        ParseAndWriteLine(value);
    }

    public void WriteLine(object value)
    {
        WriteLine(value.ToString());
    }

    private void ParseAndWriteLine(string value)
    {
        string[] delimiters = { "\n" };

        var lines = value.Split(delimiters, StringSplitOptions.None);
        foreach (var line in lines)
        {
            if (Entries.Count >= MaxEntries)
            {
                var entry = Entries.First();
                Destroy(entry);
                Entries.Remove(entry);
            }
            if(string.IsNullOrWhiteSpace(line))
            {
                WriteNewLine();
            }
            else
            {
                WriteTextLine(line);
            }
        }
    }

    private void WriteNewLine()
    {
        var newLine = GameObject.Instantiate(NewLinePrefab);
        newLine.transform.SetParent(OutputTextContainer, false);
        Entries.Add(newLine.gameObject);
    }
    private void WriteTextLine(string value)
    {
        var textLine = GameObject.Instantiate(TextLinePrefab);
        textLine.transform.SetParent(OutputTextContainer, false);
        textLine.text = value;
        Entries.Add(textLine.gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    [SerializeField]
    private TextMeshProUGUI TextLinePrefab;
    private readonly List<GameObject> Entries;
}
